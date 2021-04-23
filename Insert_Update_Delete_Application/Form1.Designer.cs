namespace Insert_Update_Delete_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_House_no = new System.Windows.Forms.TextBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_ColumnType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_MiddleName = new System.Windows.Forms.TextBox();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.comboBox_Region = new System.Windows.Forms.ComboBox();
            this.comboBox_Province = new System.Windows.Forms.ComboBox();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.comboBox_Barangay = new System.Windows.Forms.ComboBox();
            this.textBox_Zipcode = new System.Windows.Forms.TextBox();
            this.textBox_Street = new System.Windows.Forms.TextBox();
            this.textBox_District = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(206, 96);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(128, 38);
            this.textBox_LastName.TabIndex = 2;
            // 
            // textBox_House_no
            // 
            this.textBox_House_no.Location = new System.Drawing.Point(206, 140);
            this.textBox_House_no.Name = "textBox_House_no";
            this.textBox_House_no.Size = new System.Drawing.Size(128, 38);
            this.textBox_House_no.TabIndex = 5;
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(206, 315);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(128, 37);
            this.button_insert.TabIndex = 17;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(474, 315);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(128, 37);
            this.button_update.TabIndex = 19;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(337, 315);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(128, 37);
            this.button_delete.TabIndex = 18;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 394);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 254);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(706, 142);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(135, 37);
            this.button_refresh.TabIndex = 23;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Manipulation";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(706, 43);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(326, 38);
            this.textBox_Search.TabIndex = 21;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(897, 141);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(135, 37);
            this.button_search.TabIndex = 24;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // comboBox_ColumnType
            // 
            this.comboBox_ColumnType.FormattingEnabled = true;
            this.comboBox_ColumnType.Location = new System.Drawing.Point(886, 87);
            this.comboBox_ColumnType.Name = "comboBox_ColumnType";
            this.comboBox_ColumnType.Size = new System.Drawing.Size(146, 39);
            this.comboBox_ColumnType.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Search Fields";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(340, 96);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(128, 38);
            this.textBox_FirstName.TabIndex = 3;
            // 
            // textBox_MiddleName
            // 
            this.textBox_MiddleName.Location = new System.Drawing.Point(474, 96);
            this.textBox_MiddleName.Name = "textBox_MiddleName";
            this.textBox_MiddleName.Size = new System.Drawing.Size(128, 38);
            this.textBox_MiddleName.TabIndex = 4;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(206, 230);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(90, 35);
            this.radioButton_male.TabIndex = 13;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(342, 230);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(122, 35);
            this.radioButton_female.TabIndex = 14;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker_birthday.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dateTimePicker_birthday.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(206, 271);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(181, 38);
            this.dateTimePicker_birthday.TabIndex = 15;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(412, 271);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.ReadOnly = true;
            this.textBox_age.Size = new System.Drawing.Size(52, 38);
            this.textBox_age.TabIndex = 16;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(200, 55);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(29, 31);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "_";
            // 
            // comboBox_Region
            // 
            this.comboBox_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Region.FormattingEnabled = true;
            this.comboBox_Region.Items.AddRange(new object[] {
            "Region"});
            this.comboBox_Region.Location = new System.Drawing.Point(206, 184);
            this.comboBox_Region.Name = "comboBox_Region";
            this.comboBox_Region.Size = new System.Drawing.Size(128, 39);
            this.comboBox_Region.TabIndex = 8;
            this.comboBox_Region.SelectedIndexChanged += new System.EventHandler(this.comboBox_Region_Changed);
            // 
            // comboBox_Province
            // 
            this.comboBox_Province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Province.FormattingEnabled = true;
            this.comboBox_Province.Items.AddRange(new object[] {
            "Province"});
            this.comboBox_Province.Location = new System.Drawing.Point(340, 184);
            this.comboBox_Province.Name = "comboBox_Province";
            this.comboBox_Province.Size = new System.Drawing.Size(128, 39);
            this.comboBox_Province.TabIndex = 9;
            this.comboBox_Province.SelectedIndexChanged += new System.EventHandler(this.comboBox_Province_Changed);
            // 
            // comboBox_City
            // 
            this.comboBox_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Items.AddRange(new object[] {
            "City/Municipality"});
            this.comboBox_City.Location = new System.Drawing.Point(474, 184);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(128, 39);
            this.comboBox_City.TabIndex = 10;
            this.comboBox_City.SelectedIndexChanged += new System.EventHandler(this.comboBox_City_Changed);
            // 
            // comboBox_Barangay
            // 
            this.comboBox_Barangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Barangay.FormattingEnabled = true;
            this.comboBox_Barangay.Items.AddRange(new object[] {
            "Barangay"});
            this.comboBox_Barangay.Location = new System.Drawing.Point(608, 185);
            this.comboBox_Barangay.Name = "comboBox_Barangay";
            this.comboBox_Barangay.Size = new System.Drawing.Size(128, 39);
            this.comboBox_Barangay.TabIndex = 11;
            this.comboBox_Barangay.SelectedIndexChanged += new System.EventHandler(this.comboBox_Barangay_Changed);
            // 
            // textBox_Zipcode
            // 
            this.textBox_Zipcode.Location = new System.Drawing.Point(608, 230);
            this.textBox_Zipcode.Name = "textBox_Zipcode";
            this.textBox_Zipcode.ReadOnly = true;
            this.textBox_Zipcode.Size = new System.Drawing.Size(128, 38);
            this.textBox_Zipcode.TabIndex = 12;
            // 
            // textBox_Street
            // 
            this.textBox_Street.Location = new System.Drawing.Point(340, 140);
            this.textBox_Street.Name = "textBox_Street";
            this.textBox_Street.Size = new System.Drawing.Size(128, 38);
            this.textBox_Street.TabIndex = 6;
            // 
            // textBox_District
            // 
            this.textBox_District.Location = new System.Drawing.Point(474, 140);
            this.textBox_District.Name = "textBox_District";
            this.textBox_District.Size = new System.Drawing.Size(128, 38);
            this.textBox_District.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 753);
            this.Controls.Add(this.textBox_Zipcode);
            this.Controls.Add(this.comboBox_Barangay);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.comboBox_Province);
            this.Controls.Add(this.comboBox_Region);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.dateTimePicker_birthday);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.comboBox_ColumnType);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.textBox_District);
            this.Controls.Add(this.textBox_Street);
            this.Controls.Add(this.textBox_House_no);
            this.Controls.Add(this.textBox_MiddleName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_LastName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_House_no;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_ColumnType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_MiddleName;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.ComboBox comboBox_Region;
        private System.Windows.Forms.ComboBox comboBox_Province;
        private System.Windows.Forms.ComboBox comboBox_City;
        private System.Windows.Forms.ComboBox comboBox_Barangay;
        private System.Windows.Forms.TextBox textBox_Zipcode;
        private System.Windows.Forms.TextBox textBox_Street;
        private System.Windows.Forms.TextBox textBox_District;
    }
}

