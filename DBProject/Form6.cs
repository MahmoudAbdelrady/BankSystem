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

namespace DBProject
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-0B8LODU;Initial Catalog=ProjectDB;Integrated Security=True";
        private void Form6_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AdminForm = new Form4();
            AdminForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text) && String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Cannot submit empty data");
            }
            else if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Cannot submit empty data");
            }
            else
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand("insert into BRANCH values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "')", con);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Submitted information successfully");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bank Code doesn't exist");
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
