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
    public partial class editingbooks : Form
    {
        public editingbooks()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librarySystemDBDataSet);

        }

        private void editingbooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarySystemDBDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.librarySystemDBDataSet.books);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksSettings open = new BooksSettings();
            open.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\hassan hassan\Documents\Visual Studio 2015\Projects\LibrarySystem\LibrarySystem\LibrarySystemDB.mdf""; Integrated Security = True; Connect Timeout = 30");
                SqlCommand cmd = new SqlCommand("", connect);
                SqlDataReader reader;
                if (ISBNtxt.Text != ""
                    & titletxt.Text != ""
                    & authortxt.Text != ""
                    & locationtxt.Text != ""
                    & pricetxt.Text != ""
                    & genretxt.Text != ""
                    & noctxt.Text != "")
                {
                    connect.Open();
                    cmd.CommandText = "delete from books where ISBN='" + int.Parse(ISBNtxt.Text) + "' ";
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Book has been successfuly removed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\hassan hassan\Documents\Visual Studio 2015\Projects\LibrarySystem\LibrarySystem\LibrarySystemDB.mdf""; Integrated Security = True; Connect Timeout = 30");
                SqlCommand cmd = new SqlCommand("", connect);
                SqlDataReader reader;
                if (ISBNtxt.Text != ""
                    & titletxt.Text != ""
                    & authortxt.Text != ""
                    & locationtxt.Text != ""
                    & pricetxt.Text != ""
                    & genretxt.Text != ""
                    & noctxt.Text != "")
                {
                    connect.Open();
                    cmd.CommandText = "update books set ISBN='" + ISBNtxt.Text + "',Title='" + titletxt.Text + "',Author='" + authortxt.Text + "',Location='" + locationtxt.Text + "',NumberOfCopies='" + noctxt.Text + "',Price='" + pricetxt.Text + "',Genre='" + genretxt.Text + "' where ISBN='" + int.Parse(ISBNtxt.Text)+"'";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
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

        private void booksBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
