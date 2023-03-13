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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-0B8LODU;Initial Catalog=ProjectDB;Integrated Security=True";

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AdminForm = new Form4();
            AdminForm.Show();
        }

        private void Form16_Load(object sender, EventArgs e)
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
