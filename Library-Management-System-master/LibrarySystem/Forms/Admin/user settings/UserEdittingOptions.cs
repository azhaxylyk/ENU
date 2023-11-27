using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Forms.Admin.UserSettings
{
    public partial class UserEdittingOptions : Form
    {
        public UserEdittingOptions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewUser open = new AddNewUser();
            open.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage open = new AdminPage();
            open.Show();
        }

        private void UserEdittingOptions_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarySystem.Forms.Admin.user_settings.editingusers open = new user_settings.editingusers();
            open.Show();
        }
    }
}
