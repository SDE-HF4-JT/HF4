using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();

            ((Control)this.tabInbox).Enabled = false;
            ((Control)this.tabSend).Enabled = false;
        }

        //--------------------------- FORM 1 : Login -------------------------//
        //--------------------------- Tabs -----------------------------------//
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //--------------------------- Input fields ---------------------------//
        private void userInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        //------------------------- Buttons -------------------------//
        private void logInButton_Click(object sender, EventArgs e)
        {
            if (userInputBox.Text.Length == 0 || passInputBox.Text.Length == 0)
            {
                string errorMessage = "One or more fields are empty!";
                string caption = "Attention";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    //This needs to be empty!
                }
            }
            else
            {
                try
                {
                    //Empty these upon login
                    string preAccountUsername = userInputBox.Text;
                    string preAccountPassword = passInputBox.Text;

                    SQLconnect(); //Tries to connect
                }
                catch (Exception specialError)
                {
                    string errorMessage = "Error!: " + specialError;
                    string caption = "Attention";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Error);
                }
            }
        }
        //------------------------- Buttons END ---------------------//

        private void SQLconnect()
        {
            SqlConnection sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString =
                "Data Source = 62.116.202.237;" +   //Server name
                "Initial Catalog = TJDB;" +         //Database name
                "User id = SA;" +                   //User ID
                "Password = Admin123;";             //Password
            sqlConnect.Open();

            string accountUsername = userInputBox.Text;
            string accountPassword = passInputBox.Text;
            SqlDataReader reader;

            SqlCommand sqlCmd = new SqlCommand("SELECT Username, Password FROM dbo.Accounts WHERE Username == '" + accountUsername + "' AND Password == '" + accountPassword + "' ", sqlConnect);

            // PIN-POINT : 1
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
            DataTable sqlDT = new DataTable();

            sqlDA.Fill(sqlDT);
            if (sqlDT.Rows.Count > 0)
            {
                try
                {
                    String testString = "SELECT Username, Password FROM dbo.Accounts WHERE Username == '" + accountUsername + "' AND Password == '" + accountPassword + "' ";
                }
                catch (Exception e)
                {
                    string errorMessage = "Error: " + e;
                    string caption = "Attention";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Error);
                }
            }
            else
            {
                string errorMessage = "Username or Password is incorrect!";
                string caption = "Attention";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(errorMessage, caption, buttons, MessageBoxIcon.Information);
                sqlConnect.Close(); //temp
            }
            //PIN-POINT : 1 END

            //sqlConnect.Close();
        }
        //--------------------------- FORM 1 END -----------------------------//
        //--------------------------- FORM 2 : Inbox -------------------------//
        //* Label *//
        private void accountNameLabel_Click(object sender, EventArgs e)
        {
            //Important
        }
        private void InboxLabel_Click(object sender, EventArgs e)
        {

        }
        private void messageLabel_Click(object sender, EventArgs e)
        {

        }

        //* Button *//
        private void tab2_SendNewButton_Click(object sender, EventArgs e)
        {
            //Obsolete
        }
        private void inboxButton_Click(object sender, EventArgs e)
        {
            //Obsolete
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {

        }
        private void deleteMessageButton_Click(object sender, EventArgs e)
        {

        }

        //* Input field *//
        private void MessageTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        //* List *//
        private void InboxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //--------------------------- FORM 2 END -----------------------------//
        //--------------------------- FORM 3 : Send new ----------------------//
        //* Button *//
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void sendMessageButton_Click(object sender, EventArgs e)//Send message
        {

        }

        //* Input field *//
        private void recipientInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void carbonCopyInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void titleInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void messageInput_TextChanged(object sender, EventArgs e)
        {

        }

        //* Label *//
        private void recipientLabel_Click(object sender, EventArgs e)
        {

        }
        private void carbonCopyLabel_Click(object sender, EventArgs e)
        {

        }
        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
        private void timeToLiveLabel_Click(object sender, EventArgs e)
        {

        }

        //* Misc. *//
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        //--------------------------- FORM 3 END -----------------------------//
        //--------------------------- METHODS --------------------------------//
        private void TempMethod()
        {
            //On successful login:
            ((Control)this.tabLogin).Enabled = false;
            ((Control)this.tabInbox).Enabled = true;
            ((Control)this.tabSend).Enabled = true;
        }
    }
}
