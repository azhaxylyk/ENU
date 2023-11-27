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
    public partial class UserSettings : Form
    {
        public UserSettings()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librarySystemDBDataSet);

        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarySystemDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.librarySystemDBDataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage open = new AdminPage();
            open.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
