using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ADD Form3 to Form2 design as sub tab or window element hide/show toggle
namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2 form2;

        public static Form2 Instance
        {
            get
            {
                return Nested.instance;
            }
        }
        class Nested
        {
            static Nested()
            {

            }
            internal static readonly Form2 instance = new Form2();
        }

        //private Form mainForm = null;
        public Form2(/*Form callingForm*/)
        {
            //mainForm = callingForm as Form;

            InitializeComponent();

            Form2 form2 = this;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //NOTHING HAPPENS!
            if (string.Equals((sender as Button).Name, @"CloseButton"))
            {
                string errorMessage = "You are closing the program!";
                string caption = "Attention";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        //------------------------- Buttons -------------------------//
        private void sendNewButton_Click(object sender, EventArgs e)
        {
            form2.Hide();
            //form3.ShowDialog();
        }

        //Inbox button - button2
        private void inboxButton_Click(object sender, EventArgs e)
        {
            
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteMessageButton_Click(object sender, EventArgs e)
        {

        }

        //------------------------- List -------------------------//
        private void InboxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //------------------------- Readout -------------------------//
        private void MessageTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        //------------------------- Labels -------------------------//
        //Inbox label
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Message label
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Whom you are logged in as - TEMP
        private void accountNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
