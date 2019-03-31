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
    public partial class Form3 : Form
    {
        int acc = Form1.Account;
        public Form3()
        {
            InitializeComponent();
        }


        private void BalanceW_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (acc == Form2.accountnumber[0])
            {
                string amount = Convert.ToString(Form2.amount[0]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[1])
            {
                string amount = Convert.ToString(Form2.amount[1]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[2])
            {
                string amount = Convert.ToString(Form2.amount[2]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[3])
            {
                string amount = Convert.ToString(Form2.amount[3]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[4])
            {
                string amount = Convert.ToString(Form2.amount[4]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[5])
            {
                string amount = Convert.ToString(Form2.amount[5]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[6])
            {
                string amount = Convert.ToString(Form2.amount[6]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[7])
            {
                string amount = Convert.ToString(Form2.amount[7]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[8])
            {
                string amount = Convert.ToString(Form2.amount[8]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[9])
            {
                string amount = Convert.ToString(Form2.amount[9]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[10])
            {
                string amount = Convert.ToString(Form2.amount[10]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[11])
            {
                string amount = Convert.ToString(Form2.amount[11]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[12])
            {
                string amount = Convert.ToString(Form2.amount[12]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[13])
            {
                string amount = Convert.ToString(Form2.amount[13]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[14])
            {
                string amount = Convert.ToString(Form2.amount[14]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[15])
            {
                string amount = Convert.ToString(Form2.amount[15]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[16])
            {
                string amount = Convert.ToString(Form2.amount[16]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[17])
            {
                string amount = Convert.ToString(Form2.amount[17]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[18])
            {
                string amount = Convert.ToString(Form2.amount[18]);
                BalanceW.Text = amount;
            }
            if (acc == Form2.accountnumber[19])
            {
                string amount = Convert.ToString(Form2.amount[19]);
                BalanceW.Text = amount;
            }
        }

            private void EnterAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            if(acc == Form2.accountnumber[0])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[0] = Form2.amount[0] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if(acc == Form2.accountnumber[1])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[1] = Form2.amount[1] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[2])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[2] = Form2.amount[2] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[3])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[3] = Form2.amount[3] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[4])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[4] = Form2.amount[4] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[4])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[4] = Form2.amount[4] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[5])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[5] = Form2.amount[5] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[6])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[6] = Form2.amount[6] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[7])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[7] = Form2.amount[7] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[8])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[8] = Form2.amount[8] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[9])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[9] = Form2.amount[9] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[10])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[10] = Form2.amount[10] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[11])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[11] = Form2.amount[11] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[12])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[12] = Form2.amount[12] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[13])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[13] = Form2.amount[13] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[14])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[14] = Form2.amount[14] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[15])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[15] = Form2.amount[15] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[16])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[16] = Form2.amount[16] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[17])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[17] = Form2.amount[17] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[18])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[18] = Form2.amount[18] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }
            if (acc == Form2.accountnumber[19])
            {
                double withdrawamount = Convert.ToDouble(EnterAmount.Text);
                Form2.amount[19] = Form2.amount[19] - withdrawamount;
                this.Hide();
                Form3 withdrawnform = new Form3();
                withdrawnform.Show();
            }

        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newform = new Form2();
            newform.Show();
        }
    }
}
