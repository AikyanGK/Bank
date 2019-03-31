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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.name;
        }


        public static double[] amount = new double[19] { 100000, 130000, 120000, 80000, 106000, 190000, 60000, 140000, 56000, 24000, 150000, 13800, 89000, 121000, 44000, 188000, 121389, 111111, 89200 };


        private void Balance_Click(object sender, EventArgs e)
        {
            if (acc == accountnumber[0])
            {
                MessageBox.Show("         ₱" + amount[0]);    
            }
            if (acc == accountnumber[1])
            {
                MessageBox.Show("         ₱" + amount[1]);
            }
            if (acc == accountnumber[2])
            {
                MessageBox.Show("         ₱" + amount[2]);
            }
            if (acc == accountnumber[3])
            {
                MessageBox.Show("         ₱" + amount[3]);
            }
            if (acc == accountnumber[4])
            {
                MessageBox.Show("         ₱" + amount[4]);
            }
            if (acc == accountnumber[5])
            {
                MessageBox.Show("         ₱" + amount[5]);
            }
            if (acc == accountnumber[6])
            {
                MessageBox.Show("         ₱" + amount[6]);
            }
            if (acc == accountnumber[7])
            {
                MessageBox.Show("         ₱" + amount[7]);
            }
            if (acc == accountnumber[8])
            {
                MessageBox.Show("         ₱" + amount[8]);
            }
            if (acc == accountnumber[9])
            {
                MessageBox.Show("         ₱" + amount[9]);
            }
            if (acc == accountnumber[10])
            {
                MessageBox.Show("         ₱" + amount[10]);
            }
            if (acc == accountnumber[11])
            {;
                MessageBox.Show("         ₱" + amount[11]);
            }
            if (acc == accountnumber[12])
            {
                MessageBox.Show("         ₱" + amount[12]);
            }
            if (acc == accountnumber[13])
            {
                MessageBox.Show("         ₱" + amount[13]);
            }
            if (acc == accountnumber[14])
            {
                MessageBox.Show("         ₱" + amount[14]);
            }
            if (acc == accountnumber[15])
            {
                MessageBox.Show("         ₱" + amount[15]);
            }
            if (acc == accountnumber[16])
            {
                MessageBox.Show("         ₱" + amount[16]);
            }
            if (acc == accountnumber[17])
            {
                MessageBox.Show("         ₱" + amount[17]);
            }
            if (acc == accountnumber[18])
            {
                MessageBox.Show("         ₱" + amount[18]);
            }
            if (acc == accountnumber[19])
            {
                MessageBox.Show("         ₱" + amount[19]);
            }
        }


        public static int[] accountnumber = new int[20] { 01112130, 01112131, 01112132, 01112133, 01112134, 01112135, 01112136, 01112137, 01112138, 01112139, 01112140, 01112141, 01112142, 01112143, 01112145, 01112146, 01112147, 01112148, 01112149, 01112150 };
        int acc = Form1.Account;


        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.Show();
        }


        public static double Money;


        private void Withdraw_Click(object sender, EventArgs e)
        {
            if (acc == accountnumber[0])
            {
                Money = amount[0];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[1])
            {
                Money = amount[1];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[2])
            {
                Money = amount[2];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[3])
            {
                Money = amount[3];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[4])
            {
                Money = amount[4];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[5])
            {
                Money = amount[5];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[6])
            {
                Money = amount[6];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[7])
            {
                Money = amount[7];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[8])
            {
                Money = amount[8];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[9])
            {
                Money = amount[9];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[10])
            {
                Money = amount[10];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[11])
            {
                Money = amount[11];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[12])
            {
                Money = amount[12];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[13])
            {
                Money = amount[13];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[14])
            {
                Money = amount[14];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[15])
            {
                Money = amount[15];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[16])
            {
                Money = amount[16];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[17])
            {
                Money = amount[17];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[18])
            {
                Money = amount[18];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }
            if (acc == accountnumber[19])
            {
                Money = amount[19];
                this.Hide();
                Form3 withdrawform = new Form3();
                withdrawform.Show();
            }

        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            if (acc == accountnumber[0])
            {
                Money = amount[0];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[1])
            {
                Money = amount[1];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[2])
            {
                Money = amount[2];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[3])
            {
                Money = amount[3];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[4])
            {
                Money = amount[4];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[5])
            {
                Money = amount[5];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[6])
            {
                Money = amount[6];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[7])
            {
                Money = amount[7];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[8])
            {
                Money = amount[8];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[9])
            {
                Money = amount[9];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[10])
            {
                Money = amount[10];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[11])
            {
                Money = amount[11];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[12])
            {
                Money = amount[12];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[13])
            {
                Money = amount[13];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[14])
            {
                Money = amount[14];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[15])
            {
                Money = amount[15];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[16])
            {
                Money = amount[16];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[17])
            {
                Money = amount[17];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[18])
            {
                Money = amount[18];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
            if (acc == accountnumber[19])
            {
                Money = amount[19];
                this.Hide();
                Form4 depositform = new Form4();
                depositform.Show();
            }
        }
    }
}
