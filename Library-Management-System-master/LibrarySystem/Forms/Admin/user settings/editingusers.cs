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

namespace LibrarySystem.Forms.Admin.user_settings
{
    public partial class editingusers : Form
    {
        public editingusers()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librarySystemDBDataSet);

        }

        private void editingusers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarySystemDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.librarySystemDBDataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarySystem.Forms.Admin.UserSettings.UserEdittingOptions open = new UserSettings.UserEdittingOptions();
            open.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\hassan hassan\Documents\Visual Studio 2015\Projects\LibrarySystem\LibrarySystem\LibrarySystemDB.mdf""; Integrated Security = True; Connect Timeout = 30");
                SqlCommand cmd = new SqlCommand("", connect);
                if (iDTextBox.Text != ""
                    & first_NameTextBox.Text != ""
                    & last_NameTextBox.Text != ""
                    & passwordTextBox.Text != ""
                    & phoneTextBox.Text != ""
                    & addressTextBox.Text != ""
                    & emailTextBox.Text != "")
                {
                    connect.Open();
                    cmd.CommandText = "update Users set ID='" + iDTextBox.Text + "',[First Name]='" + first_NameTextBox.Text + "',[Last Name]='" + last_NameTextBox.Text + "',Password='" + passwordTextBox.Text + "',Phone='" + phoneTextBox.Text + "',Address='" + addressTextBox.Text + "',Email='" + emailTextBox.Text + "' where ID='" + int.Parse(iDTextBox.Text) + "'";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    MessageBox.Show("User has been successfuly Removed");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\hassan hassan\Documents\Visual Studio 2015\Projects\LibrarySystem\LibrarySystem\LibrarySystemDB.mdf""; Integrated Security = True; Connect Timeout = 30");
                SqlCommand cmd = new SqlCommand("", connect);
                if (iDTextBox.Text != ""
                    & first_NameTextBox.Text != ""
                    & last_NameTextBox.Text != ""
                    & passwordTextBox.Text != ""
                    & phoneTextBox.Text != ""
                    & addressTextBox.Text != ""
                    & emailTextBox.Text != "")
                {
                    connect.Open();
                    cmd.CommandText = "delete from Users where ID='" + int.Parse(iDTextBox.Text) + "'";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    this.Hide();
                    this.Show();
                    MessageBox.Show("Data has been successfuly updated");
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
