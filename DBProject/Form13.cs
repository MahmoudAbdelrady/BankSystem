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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-0B8LODU;Initial Catalog=ProjectDB;Integrated Security=True";
        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UpForm = new Form14();
            UpForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text) && String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox4.Text) && String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Cannot submit empty data");
            }
            else if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Cannot submit empty data");
            }
            else
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand("update EMPLOYEE set NAME = '" + textBox2.Text.ToString() + "'Where SSN ='" + textBox1.Text.ToString() + "'", con);
                    myCommand.ExecuteNonQuery();
                    myCommand = new SqlCommand("update EMPLOYEE set BRANCHNUM = '" + textBox3.Text.ToString() + "'Where SSN ='" + textBox1.Text.ToString() + "'", con);
                    myCommand.ExecuteNonQuery();
                    myCommand = new SqlCommand("update EMPLOYEE set PHONE = '" + textBox4.Text.ToString() + "'Where SSN ='" + textBox1.Text.ToString() + "'", con);
                    myCommand.ExecuteNonQuery();
                    myCommand = new SqlCommand("update EMPLOYEE set ADDRESS = '" + textBox5.Text.ToString() + "'Where SSN ='" + textBox1.Text.ToString() + "'", con);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Updated employee information successfully");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Employee doesn't exist");
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
