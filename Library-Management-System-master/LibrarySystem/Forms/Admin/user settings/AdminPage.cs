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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarySystem.Forms.Admin.UserSettings.UserEdittingOptions open = new Forms.Admin.UserSettings.UserEdittingOptions();
            open.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksSettings open = new BooksSettings();
            open.Show();
        }
    }
}
