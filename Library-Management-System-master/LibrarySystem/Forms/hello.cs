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
    public partial class hello : Form
    {
        public hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hello_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Car\Library-Management-System-master\LibrarySystem\LibrarySystemDB.mdf""; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter adp = new SqlDataAdapter("Select Email , Password , Type From Users", con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            SqlCommand cmd = new SqlCommand("",con);
            con.Open();
            cmd.CommandText = "SELECT COUNT(*) FROM Users";
            Int32 count = (Int32)cmd.ExecuteScalar();
            try
            {
                for (int i = 0; i < count; i++)
                {
                    if (tbl.Rows[i][0].ToString() == textBox1.Text && tbl.Rows[i][1].ToString() == textBox2.Text)
                    {
                        if (tbl.Rows[i][2].ToString() == "True")
                        {
                            this.Hide();
                            AdminPage open = new AdminPage();
                            open.Show();
                        }
                        else {
                            this.Hide();
                            Main open = new Main();
                            open.Show();

                        }
                        return;
                    }
                }
                MessageBox.Show("invalid email / Password please enter the correct email / Password");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
