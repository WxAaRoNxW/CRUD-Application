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
    interface IFirstInterface
    {
        void myMethod(); // interface method

    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }



    public partial class MultipleInterface : Form, IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            MessageBox.Show("Some text..");
        }
        public void myOtherMethod()
        {
            MessageBox.Show("Some other text...");
        }



        public MultipleInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MultipleInterface myObj = new MultipleInterface();
            myObj.myMethod();
            myObj.myOtherMethod();
        }
    }
}
