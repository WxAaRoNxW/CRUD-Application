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
    // Interface
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

   
    public partial class InterfaceUI : Form, IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            MessageBox.Show("The pig says: wee wee");
        }

        public InterfaceUI()
        {
            InitializeComponent();
        }

        private void InterfaceUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterfaceUI myPig = new InterfaceUI();  // Create a Pig object
            myPig.animalSound();
        }
    }
}
