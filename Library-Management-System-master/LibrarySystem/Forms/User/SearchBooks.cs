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

namespace LibrarySystem
{
    public partial class SearchBooks : Form
    {
        public SearchBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (textBox1.Text != "")
                {
                    listBox1.Items.Clear();
                    SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Car\Library-Management-System-master\LibrarySystem\LibrarySystemDB.mdf""; Integrated Security = True; Connect Timeout = 30");
                    SqlCommand cmd = new SqlCommand("", connect);
                    SqlDataReader reader;
                    connect.Open();
                    cmd.CommandText = "select * from books where Title='"+textBox1.Text+"'";
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows) {
                        while (reader.Read())
                        {
                            listBox1.Items.Add("ISBN: " + reader[0].ToString());
                            listBox1.Items.Add("Title: " + reader[1].ToString());
                            listBox1.Items.Add("Author: " + reader[2].ToString());
                            listBox1.Items.Add("Location: " + reader[3].ToString());
                            listBox1.Items.Add("Copies Available: " + reader[4].ToString());
                            listBox1.Items.Add("Price: " + reader[5].ToString());
                            listBox1.Items.Add("Genre: " + reader[6].ToString());
                        }
                        
                    } else {
                        MessageBox.Show("Books was not found.");
                    }
                    connect.Close();
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main open = new Main();
            open.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
