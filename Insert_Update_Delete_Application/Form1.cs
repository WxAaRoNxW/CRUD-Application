using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Insert_Update_Delete_Application
{
    public partial class Form1 : Form
    {                      // servername          username    password     databasename
        string table_Person_Name = "person_tbl";
        string table_Person_Address_Name = "person_add_tbl";
        string table_Region_Name = "region_tbl";
        string mycon = "datasource=localhost; username=root; password=; database=crud_winappdb;";
        private enum defaultAdd { 
            regi,
            prov,
            city,
            bara
        }

        string[] defaultValues = new string[] {
            "Region",
            "Province",
            "City",
            "Barangay"
        };

        public void ClearFields()
        {
            label_ID.Text = "_";
            textBox_LastName.Text = "";
            textBox_FirstName.Text = "";
            textBox_MiddleName.Text = "";
            textBox_House_no.Text = "";
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            clearDropDown(new ComboBox[] { comboBox_Province, comboBox_City, comboBox_Barangay });
            textBox_Zipcode.Text = "";
            textBox_House_no.Text = "";
        }

        private bool checkEmptyFieldsMain(string[] texts)
        {
            foreach (string input in texts) {
                if (String.IsNullOrEmpty(input)) {
                    return true;
                }
            }
            return false;
        }
        private bool checkEmptyFieldsAddress(string[] texts, string[] comboBoxes)
        {
            foreach (string input in texts)
            {
                if (String.IsNullOrEmpty(input))
                {
                    return true;
                }
            }
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                if (comboBoxes[i] == defaultValues[i])
                {
                    return true;
                }
            }
            return false;
        }

        public Form1()
        {
            InitializeComponent();
            ComboBox[] comboBoxes = new ComboBox[] {
                comboBox_Region,
                comboBox_Province,
                comboBox_City,
                comboBox_Barangay
            };
            foreach (ComboBox comboBox in comboBoxes) {
                comboBox.SelectedIndex = 0;
            }
            ImportDropDown("region", comboBox_Region);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_insert.BackColor = Color.FromArgb(0, 121, 107);
            button_update.BackColor = Color.FromArgb(222, 152, 22);
            button_delete.BackColor = Color.FromArgb(194, 36, 25);
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            ShowAllData();
        }

        public void ShowAllData()
        {
            try
            {
                string query =  "SELECT " + table_Person_Name + ".*, " + table_Person_Address_Name + ".* " +
                                "FROM " + table_Person_Name + " INNER JOIN " + table_Person_Address_Name + " " +
                                "ON " + table_Person_Name + ".person_id = " + table_Person_Address_Name + ".person_id;";
                MySqlConnection myCon2 = new MySqlConnection(mycon);
                MySqlCommand myCommand = new MySqlCommand(query, myCon2);
                MySqlDataAdapter myadapter = new MySqlDataAdapter();
                myadapter.SelectCommand = myCommand;
                DataTable dtable = new DataTable();
                myadapter.Fill(dtable);
                dataGridView1.DataSource = dtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("error in show all data");
            }
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                string query = CheckQuery(true, true);
                string query2 = CheckQuery(false, true);
                if (!String.IsNullOrWhiteSpace(query) && !String.IsNullOrWhiteSpace(query2)) {
                    query =     "INSERT INTO " +
                                table_Person_Name + "(lastname, firstname, middlename, gender, birthday, age) " +
                                "VALUES(" + query + ");";
                    MessageBox.Show("query = " + query);
                    MySqlConnection myCon2 = new MySqlConnection(mycon);
                    MySqlCommand myCommand = new MySqlCommand(query, myCon2);
                    MySqlDataReader MyReader1;
                    myCon2.Open();
                    MyReader1 = myCommand.ExecuteReader();
                    int id = (int)myCommand.LastInsertedId;
                    myCon2.Close();

                    query2 =    "INSERT INTO " +
                                table_Person_Address_Name + "(person_id, house_no, street, district, barangay, city, province, zipcode, region) " +
                                "VALUES('" + id + "', " + query2 + ");";
                    MessageBox.Show("query = " + query2);
                    myCommand = new MySqlCommand(query2, myCon2);
                    myCon2.Open();

                    MyReader1 = myCommand.ExecuteReader();
                    MessageBox.Show("Data is inserted");
                    ClearFields();
                    ShowAllData();
                    myCon2.Close();
                } else {
                    MessageBox.Show("Missing Fields");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("error in insert");
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = CheckQuery(true, false);
                string query2 = CheckQuery(false, false);
                if (!String.IsNullOrWhiteSpace(query) && !String.IsNullOrWhiteSpace(query2)) { 
                    query =     "UPDATE " + table_Person_Name + " SET " + query +
                                "WHERE person_id = '" + label_ID.Text + "';";
                    query2 =    "UPDATE " + table_Person_Address_Name + " SET " + query2 +
                                "WHERE person_id = '" + label_ID.Text + "';";
                    MySqlConnection myCon2 = new MySqlConnection(mycon);
                    MySqlCommand myCommand = new MySqlCommand(query, myCon2);
                    MySqlDataReader MyReader1;
                    myCon2.Open();
                    MyReader1 = myCommand.ExecuteReader();
                    MessageBox.Show("Data is Updated");
                    ClearFields();
                    ShowAllData();

                    myCon2.Close();
                } else {
                    MessageBox.Show("Missing Fields");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("error in update");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "DELETE FROM" + table_Person_Name + " WHERE person_id= '" + this.label_ID.Text + "';";
                MySqlConnection myCon2 = new MySqlConnection(mycon);
                MySqlCommand myCommand = new MySqlCommand(query, myCon2);
                MySqlDataReader MyReader1;
                myCon2.Open();
                MyReader1 = myCommand.ExecuteReader();

                query = "DELETE FROM " + table_Person_Address_Name + " WHERE person_id= '" + this.label_ID.Text + "';";
                myCommand = new MySqlCommand(query, myCon2);
                MyReader1 = myCommand.ExecuteReader();
                MessageBox.Show("Data is Deleted");
                ClearFields();
                ShowAllData();
                myCon2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                ShowAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label_ID.Text = row.Cells["person_id"].Value.ToString();
                textBox_LastName.Text = row.Cells["lastname"].Value.ToString();
                textBox_FirstName.Text = row.Cells["firstname"].Value.ToString();
                textBox_MiddleName.Text = row.Cells["middlename"].Value.ToString();

                textBox_House_no.Text = row.Cells["house_no"].Value.ToString();
                textBox_Street.Text = row.Cells["street"].Value.ToString();
                textBox_District.Text = row.Cells["district"].Value.ToString();

                comboBox_Region.SelectedIndex = comboBox_Region.FindStringExact(row.Cells["region"].Value.ToString());
                readyImportDropDown(comboBox_Region.Text, defaultValues[(int)defaultAdd.regi], "province", comboBox_Province, "region");

                comboBox_Province.SelectedIndex = comboBox_Province.FindStringExact(row.Cells["province"].Value.ToString());
                readyImportDropDown(comboBox_Province.Text, defaultValues[(int)defaultAdd.prov], "city_mun", comboBox_City, "province");

                comboBox_City.SelectedIndex = comboBox_City.FindStringExact(row.Cells["city"].Value.ToString());
                readyImportDropDown(comboBox_City.Text, defaultValues[(int)defaultAdd.city], "barangay", comboBox_Barangay, "city_mun");

                comboBox_Barangay.SelectedIndex = comboBox_Barangay.FindStringExact(row.Cells["barangay"].Value.ToString());

                textBox_Zipcode.Text = row.Cells["zipcode"].Value.ToString();
                string gender = row.Cells["gender"].Value.ToString();
                if (gender == "Male") {
                    radioButton_male.Checked = true;
                } else if (gender == "Female") {
                    radioButton_female.Checked = true;
                }
                dateTimePicker_birthday.Text = row.Cells["birthday"].Value.ToString();
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string filter = comboBox_ColumnType.Text;
            string searchBox = this.textBox_Search.Text;
            bool isSearchBoxEmpty = searchBox != null && searchBox != "";

            try
            {
                //Display query  
                string query = isSearchBoxEmpty ? "Select * from " + table_Person_Name + " where " + filter + "='" + searchBox + "';" : "Select * from " + table_Person_Name + ";";
                DataTable dTable = QueryPost(query);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // method to reimport new data from a combo list, if chosen NCR, the province, city, and barangay will change their dropdown list
        private void ImportDropDown(string columnToSelect, ComboBox comboBoxToApply, string conditionToCheck = "", string valueToCheck = "") {

            string conditionStart = "";
            string conditionEnd = "";
            if (!String.IsNullOrWhiteSpace(conditionToCheck)) {
                conditionStart = " WHERE " + conditionToCheck + " = '";
                conditionEnd = "'";
            }
            try
            {
                string query = "SELECT DISTINCT " + columnToSelect + " FROM " + table_Region_Name + conditionStart + valueToCheck + conditionEnd + ";";
                DataTable dtable = QueryPost(query);
                foreach (DataRow row in dtable.Rows) {
                    comboBoxToApply.Items.Add(row[columnToSelect].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // When the dropdown list changes selection, reimport the new data for the dropdowns below the heiarchy
        #region Reimport new database on dropdown list change selection
        private void comboBox_Region_Changed(object sender, EventArgs e) {
            clearDropDown(new ComboBox[]{comboBox_Province, comboBox_City, comboBox_Barangay});
            readyImportDropDown(comboBox_Region.Text, defaultValues[(int) defaultAdd.regi], "province", comboBox_Province, "region");
        }

        private void comboBox_Province_Changed(object sender, EventArgs e) {
            clearDropDown(new ComboBox[] { comboBox_City, comboBox_Barangay });
            readyImportDropDown(comboBox_Province.Text, defaultValues[(int)defaultAdd.prov], "city_mun", comboBox_City, "province");
        }

        private void comboBox_City_Changed(object sender, EventArgs e) {
            clearDropDown(new ComboBox[] { comboBox_Barangay });
            readyImportDropDown(comboBox_City.Text, defaultValues[(int)defaultAdd.city], "barangay", comboBox_Barangay, "city_mun");
        }

        private void comboBox_Barangay_Changed(object sender, EventArgs e) {
            try
            {
                string query = "SELECT zipcode FROM " + table_Region_Name + " WHERE barangay = '" + comboBox_Barangay.Text + "';";
                MySqlConnection myCon2 = new MySqlConnection(mycon);
                MySqlCommand myCommand = new MySqlCommand(query, myCon2);
                MySqlDataAdapter myadapter = new MySqlDataAdapter();
                myadapter.SelectCommand = myCommand;
                DataTable dtable = new DataTable();
                myadapter.Fill(dtable);
                foreach (DataRow row in dtable.Rows)
                {
                    textBox_Zipcode.Text = (row["zipcode"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Drop down methods
        // another method was used for this to check if the user selected the default value ("choose a region", etc)which is not part of the category
        private void readyImportDropDown(string comboBoxValueToCheck, string comboBoxDefaultToCheck, string columnToSelect, ComboBox comboBoxToApply, string conditionToCheck) {
            if (comboBoxValueToCheck != comboBoxDefaultToCheck)
            {
                // import data
                ImportDropDown(columnToSelect, comboBoxToApply, conditionToCheck, comboBoxValueToCheck);
            }
        }

        // clear the dropdown menu for when there's a selection change
        private void clearDropDown(ComboBox[] comboBoxes) {
            foreach (ComboBox comboBox in comboBoxes) {
                string defaultVal = comboBox.Items[0].ToString();
                comboBox.Items.Clear();
                //comboBox.ResetText();
                comboBox.Items.Add(defaultVal);
                comboBox.SelectedIndex = comboBox.FindStringExact(defaultVal);
            }
            textBox_Zipcode.Text = "";
        }
        #endregion

        // method to create a query with the inputs and to also check if it's empty
        private string CheckQuery(bool isMainTbl, bool isInsert)
        {
            if (isMainTbl)
            {
                string id       = this.label_ID.Text;
                string lName    = this.textBox_LastName.Text;
                string fName    = this.textBox_FirstName.Text;
                string mName    = this.textBox_MiddleName.Text;
                string gender   = null;
                string birthday = this.dateTimePicker_birthday.Value.ToString("yyyy/MM/dd");
                int age = 99;

                if (radioButton_male.Checked)
                {
                    gender = radioButton_male.Text;
                }
                else if (radioButton_female.Checked)
                {
                    gender = radioButton_female.Text;
                }
                if (checkEmptyFieldsMain(new string[] {lName, fName, mName, gender, birthday }))
                {
                    return "";
                }

                if (isInsert) {
                    return  "'" + lName + "', " +
                            "'" + fName + "', " +
                            "'" + mName + "', " +
                            "'" + gender + "', " +
                            "'" + birthday + "', " +
                            "'" + age + "'";
                } else {
                    return  "lastname = '" + lName + "', " +
                            "firstname = '" + fName + "', " +
                            "middlename = '" + mName + "', " +
                            "gender = '" + gender + "', " +
                            "birthday = '" + birthday + "', " +
                            "age = '" + age + "'";
                }
            } else {
                string house_no = this.textBox_House_no.Text;
                string street   = this.textBox_Street.Text;
                string district = this.textBox_District.Text;
                string barangay = this.comboBox_Barangay.SelectedItem.ToString();
                string city     = this.comboBox_City.SelectedItem.ToString();
                string province = this.comboBox_Province.SelectedItem.ToString();
                string zip      = this.textBox_Zipcode.Text;
                string region   = this.comboBox_Region.SelectedItem.ToString();

                if (checkEmptyFieldsAddress(new string[] { house_no, street, district, zip }, new string[] { region, province, city, barangay } ) ) {
                    return "";
                }

                if (isInsert)
                {
                    return  "'" + house_no + "', " +
                            "'" + street + "', " +
                            "'" + district + "', " +
                            "'" + barangay + "', " +
                            "'" + city + "', " +
                            "'" + province + "', " +
                            "'" + zip + "', " +
                            "'" + region + "'";
                } else {
                    return  "house_no = '" + house_no + "', " +
                            "street = '" + street + "', " +
                            "district = '" + district + "', " +
                            "barangay = '" + barangay + "', " +
                            "city = '" + city + "', " +
                            "province = '" + province + "', " +
                            "zipcode = '" + zip + "', " +
                            "region = '" + region + "'";
                }
            }

        }

        // execute query command
        private DataTable QueryPost(string query) {
            MySqlConnection MyConn = new MySqlConnection(mycon);
            MySqlCommand myCommand = new MySqlCommand(query, MyConn);
            //  MyConn2.Open();  
            //For offline connection we weill use  MySqlDataAdapter class.  
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = myCommand;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            
            return dTable;
        }
    }
}
