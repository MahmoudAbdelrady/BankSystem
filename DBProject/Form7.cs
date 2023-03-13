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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-0B8LODU;Initial Catalog=ProjectDB;Integrated Security=True";
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var EmployeeForm = new Form2();
            EmployeeForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text) && String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox4.Text) && String.IsNullOrEmpty(textBox5.Text) && String.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Cannot submit empty data");
            }
            else if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Cannot submit empty data");
            }
            else
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand("insert into CUSTOMER values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "')", con);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Submitted information successfully");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Employee SSN doesn't exist or SSN already exists");
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
