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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-0B8LODU;Initial Catalog=ProjectDB;Integrated Security=True";

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AdminForm = new Form1();
            AdminForm.Show();
        }
        private void Form12_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "SELECT BRANCH.BRANCHNUM FROM BRANCH WHERE BRANCH.BRANCHNUM NOT IN(SELECT CUSTOMER.BRANCHNUM FROM CUSTOMER)";
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dataGridView1.DataSource = tb;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "SELECT BRANCH.BRANCHNUM FROM BRANCH WHERE BRANCH.BRANCHNUM NOT IN(SELECT EMPLOYEE.BRANCHNUM FROM EMPLOYEE)";
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dataGridView1.DataSource = tb;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query =
                "SELECT EMPLOYEE.EMP_NAME FROM EMPLOYEE, PERFORM WHERE EMPLOYEE.EMP_SSN = PERFORM.EMP_SSN GROUP BY EMPLOYEE.EMP_NAME HAVING COUNT(EMPLOYEE.EMP_NAME) = (SELECT MAX(MAXIMUM) FROM( SELECT  COUNT(EMPLOYEE.EMP_NAME)AS MAXIMUM, EMPLOYEE.EMP_NAME FROM EMPLOYEE, PERFORM WHERE EMPLOYEE.EMP_SSN = PERFORM.EMP_SSN GROUP BY EMPLOYEE.EMP_NAME )AS NAME)";
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dataGridView1.DataSource = tb;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query =
                "SELECT CUSTOMER.NAME FROM CUSTOMER, TAKE WHERE CUSTOMER.SSN = TAKE.SSN GROUP BY CUSTOMER.NAME HAVING COUNT(CUSTOMER.NAME) = (SELECT MAX(MAXIMUM) FROM( SELECT  COUNT(CUSTOMER.NAME)AS MAXIMUM, CUSTOMER.NAME FROM CUSTOMER, TAKE WHERE CUSTOMER.SSN = TAKE.SSN GROUP BY CUSTOMER.NAME)AS NAME) ";
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dataGridView1.DataSource = tb;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "SELECT CUSTOMER.NAME FROM CUSTOMER WHERE CUSTOMER.NAME NOT IN(SELECT CUSTOMER.NAME FROM CUSTOMER, TAKE WHERE CUSTOMER.SSN = TAKE.SSN)";
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dataGridView1.DataSource = tb;
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = 
                "SELECT LOAN.LOANNUM,CUSTOMER.NAME,EMPLOYEE.EMP_NAME FROM CUSTOMER, EMPLOYEE, TAKE, LOAN WHERE CUSTOMER.EMP_SSN = EMPLOYEE.EMP_SSN AND CUSTOMER.SSN = TAKE.SSN AND TAKE.LOANNUM = LOAN.LOANNUM";
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dataGridView1.DataSource = tb;
            con.Close();
        }
    }
}
