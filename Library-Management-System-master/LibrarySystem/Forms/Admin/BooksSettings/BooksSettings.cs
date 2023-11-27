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
    public partial class BooksSettings : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\hassan hassan\Documents\Visual Studio 2015\Projects\LibrarySystem\LibrarySystem\LibrarySystemDB.mdf""; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public BooksSettings()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librarySystemDBDataSet);

        }

        private void BooksSettings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarySystemDBDataSet.books' table. You can move, or remove it, as needed.
            cmd.Connection = connect;
            this.booksTableAdapter.Fill(this.librarySystemDBDataSet.books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage close = new AdminPage();
            close.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewBook open = new AddNewBook();
            open.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            editingbooks open = new editingbooks();
            open.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
