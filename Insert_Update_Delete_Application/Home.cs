using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insert_Update_Delete_Application
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            pictureBox5.Hide();
            panel2.Hide();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            pictureBox5.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.Show();
            pictureBox5.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }
    }
}
 