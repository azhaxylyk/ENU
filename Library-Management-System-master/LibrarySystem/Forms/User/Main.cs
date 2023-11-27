using LibrarySystem.Forms.User;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books open = new Books();
            open.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchBooks open = new SearchBooks();
            open.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requests open = new Requests();
            open.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
