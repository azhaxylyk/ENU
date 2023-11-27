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
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\hassan hassan\Documents\Visual Studio 2015\Projects\LibrarySystem\LibrarySystem\LibrarySystemDB.mdf""; Integrated Security = True; Connect Timeout = 30");
                SqlCommand cmd = new SqlCommand("", connect);
                if (ISBNtxt.Text != ""
                    & titletxt.Text != ""
                    & authortxt.Text != ""
                    & locationtxt.Text != ""
                    & pricetxt.Text != ""
                    & genretxt.Text != ""
                    & noctxt.Text != "")
                {
                    connect.Open();
                    cmd.CommandText = "insert into books (ISBN,Title,Author,Location,NumberOfCopies,Price,Genre) values ('" + ISBNtxt.Text + "','" + titletxt.Text + "','" + authortxt.Text + "','" + locationtxt.Text + "','" + noctxt.Text + "','" + pricetxt.Text + "','" + genretxt.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    MessageBox.Show("Data has been successfuly added");

                }
                else
                {
                    MessageBox.Show("empty fields are not allowed ! please make sure every data has been added");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksSettings open = new BooksSettings();
            open.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
