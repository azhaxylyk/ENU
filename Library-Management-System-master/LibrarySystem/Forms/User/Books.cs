using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librarySystemDBDataSet);

        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarySystemDBDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.librarySystemDBDataSet.books);

        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main open = new Main();
            open.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.User.Requests open = new Forms.User.Requests();
            open.Show();
        }
    }
}
