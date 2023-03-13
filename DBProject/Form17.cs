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
    public partial class Form17 : Form
    {
        Form3 RequestLoan;
        public Form17(Form3 RqLoan)
        {
            InitializeComponent();
            this.RequestLoan = RqLoan;
        }

        public string conString = "Data Source=DESKTOP-0B8LODU;Initial Catalog=ProjectDB;Integrated Security=True";

        private void Form17_Load(object sender, EventArgs e)
        {
            textBox4.Text = RequestLoan.textBox3.Text;
            textBox1.Text = RequestLoan.textBox1.Text;
            textBox3.Text = RequestLoan.textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
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
                    SqlCommand myCommand = new SqlCommand("insert into LOAN values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString()+ "','" + "Accepted" + "')", con);
                    myCommand.ExecuteNonQuery();
                    myCommand = new SqlCommand("insert into TAKE values ('" + textBox4.Text.ToString() + "','" + textBox2.Text.ToString() + "')", con);
                    myCommand.ExecuteNonQuery();
                    myCommand = new SqlCommand("insert into PERFORM values ('" + textBox5.Text.ToString() + "','" + textBox2.Text.ToString() + "')", con);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Loan Accepted");
                    this.Hide();
                    RequestLoan.textBox1.Clear();
                    RequestLoan.textBox2.Clear();
                    RequestLoan.textBox3.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SSN or Employee SSN doesn't exist");
                }
                finally
                {
                    con.Close();
                }
            }
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
                    SqlCommand myCommand = new SqlCommand("insert into LOAN values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + "Rejected" + "')", con);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Loan Rejected");
                    this.Hide();
                    RequestLoan.textBox1.Clear();
                    RequestLoan.textBox2.Clear();
                    RequestLoan.textBox3.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SSN or Employee SSN doesn't exist");
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
