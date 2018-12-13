using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3 form3;

        public static LoginWindow Instance
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
            internal static readonly LoginWindow instance = new LoginWindow();
        }
        public Form3()
        {
            InitializeComponent();

            Form3 form3 = this;
        }

        //----------------- Buttons --------------------//
        private void sendNewButton_Click(object sender, EventArgs e)
        {

        }

        private void inboxButton_Click(object sender, EventArgs e)
        {
            //form2.ShowDialog();
            form3.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {

        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {

        }

        //-------------------------- Input --------------------------//
        private void recipientInput_TextChanged(object sender, EventArgs e)
        {

        }
        //Previously: textBox2
        private void carbonCopyInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleInput_TextChanged(object sender, EventArgs e)
        {

        }

        //private void timeToLiveInput_TextChanged(object sender, EventArgs e)
        //{
        //
        //}
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        //---------------- Main message input field ---------------------//
        private void messageInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
