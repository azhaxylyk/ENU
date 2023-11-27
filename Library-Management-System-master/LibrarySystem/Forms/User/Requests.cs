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

namespace LibrarySystem.Forms.User
{
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books open = new Books();
            open.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Car\Library-Management-System-master\LibrarySystem\LibrarySystemDB.mdf""; Integrated Security = True; Connect Timeout = 30");
                SqlCommand cmd = new SqlCommand("", connect);
                connect.Open();
                if (idTextBox.Text != "" & isbnTextBox.Text != "")
                {
                    cmd.CommandText = "insert into Requests (Type,[Request Date],[Due Date],ID,ISBN) values ('" + borrowCheckBox.Checked + "','" + requestdateTimePicker.Value + "','" + duedateTimePicker.Value + "','" + idTextBox.Text + "','" + isbnTextBox.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    MessageBox.Show("Books has been successfully purchased");
                } else
                {
                    MessageBox.Show("insufficient data");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            
        }
    }
}
