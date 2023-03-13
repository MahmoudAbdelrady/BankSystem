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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-0B8LODU;Initial Catalog=ProjectDB;Integrated Security=True";
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AdminForm = new Form1();
            AdminForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AddBank = new Form5();
            AddBank.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AddBankBranch = new Form6();
            AddBankBranch.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SignUpNU = new Form8();
            SignUpNU.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UpdateUD = new Form14();
            UpdateUD.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LoansList = new Form10();
            LoansList.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LoansListWName = new Form16();
            LoansListWName.Show();
        }
    }
}
