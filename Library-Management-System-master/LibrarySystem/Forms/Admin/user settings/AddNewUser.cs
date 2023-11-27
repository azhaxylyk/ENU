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

namespace LibrarySystem.Forms.Admin.UserSettings
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserEdittingOptions open = new UserEdittingOptions();
            open.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\hassan hassan\Documents\Visual Studio 2015\Projects\LibrarySystem\LibrarySystem\LibrarySystemDB.mdf""; Integrated Security = True; Connect Timeout = 30");
                SqlCommand cmd = new SqlCommand("", connect);
                if (iDTextBox.Text != ""
                    & first_nameTextBox.Text != ""
                    & last_nameTextBox.Text != ""
                    & passwordTextBox.Text != ""
                    & phoneTextBox.Text != ""
                    & addressTextBox.Text != ""
                    & emailTextBox.Text != "")
                {
                    connect.Open();
                    cmd.CommandText = "insert into Users (ID,[First Name],[Last Name],Password,Type,isBlocked,Phone,Address,Email) values ('" + iDTextBox.Text + "' , '" + first_nameTextBox.Text + "','" + last_nameTextBox.Text + "','" + passwordTextBox.Text + "','" + typeCheckBox.Checked + "' , '" + blockCheckBox.Checked + "' , '" + phoneTextBox.Text + "','" + addressTextBox.Text + "','" + emailTextBox.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    this.Hide();
                    this.Show();
                    MessageBox.Show("User has been successfuly Added To Library");
                }
                else
                {
                    MessageBox.Show("empty fields are not allowed ! please make sure every data has been added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
