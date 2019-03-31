using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA4_Carreon
{
    public partial class Form4 : Form
    {
        int acc = Form1.Account;
        public Form4()
        {
            InitializeComponent();
        }


        private void BalanceW_Click_1(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (acc == Form2.accountnumber[0])
            {
                string amount = Convert.ToString(Form2.amount[0]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[1])
            {
                string amount = Convert.ToString(Form2.amount[1]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[2])
            {
                string amount = Convert.ToString(Form2.amount[2]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[3])
            {
                string amount = Convert.ToString(Form2.amount[3]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[4])
            {
                string amount = Convert.ToString(Form2.amount[4]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[5])
            {
                string amount = Convert.ToString(Form2.amount[5]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[6])
            {
                string amount = Convert.ToString(Form2.amount[6]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[7])
            {
                string amount = Convert.ToString(Form2.amount[7]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[8])
            {
                string amount = Convert.ToString(Form2.amount[8]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[9])
            {
                string amount = Convert.ToString(Form2.amount[9]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[10])
            {
                string amount = Convert.ToString(Form2.amount[10]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[11])
            {
                string amount = Convert.ToString(Form2.amount[11]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[12])
            {
                string amount = Convert.ToString(Form2.amount[12]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[13])
            {
                string amount = Convert.ToString(Form2.amount[13]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[14])
            {
                string amount = Convert.ToString(Form2.amount[14]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[15])
            {
                string amount = Convert.ToString(Form2.amount[15]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[16])
            {
                string amount = Convert.ToString(Form2.amount[16]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[17])
            {
                string amount = Convert.ToString(Form2.amount[17]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[18])
            {
                string amount = Convert.ToString(Form2.amount[18]);
                BalanceD.Text = amount;
            }
            if (acc == Form2.accountnumber[19])
            {
                string amount = Convert.ToString(Form2.amount[19]);
                BalanceD.Text = amount;
            }
        }

        private void EnterAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deposit_Click(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newform = new Form2();
            newform.Show();
        }

        private void Deposit_Click_1(object sender, EventArgs e)
        {
            if (acc == Form2.accountnumber[0])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[0] = Form2.amount[0] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[1])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[1] = Form2.amount[1] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[2])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[2] = Form2.amount[2] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[3])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[3] = Form2.amount[3] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[4])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[4] = Form2.amount[4] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[5])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[5] = Form2.amount[5] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[6])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[6] = Form2.amount[6] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[7])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[7] = Form2.amount[7] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[8])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[8] = Form2.amount[8] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[9])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[9] = Form2.amount[9] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[10])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[10] = Form2.amount[10] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[11])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[11] = Form2.amount[11] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[12])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[12] = Form2.amount[12] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[13])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[13] = Form2.amount[13] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[14])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[14] = Form2.amount[14] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[15])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[15] = Form2.amount[15] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[16])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[16] = Form2.amount[16] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[17])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[17] = Form2.amount[17] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[18])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[18] = Form2.amount[18] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
            if (acc == Form2.accountnumber[19])
            {
                double depositamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[19] = Form2.amount[19] + depositamount;
                this.Hide();
                Form4 deposit = new Form4();
                deposit.Show();
            }
        }

        private void EnterAmount_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Done_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newform = new Form2();
            newform.Show();
        }
    }
}
