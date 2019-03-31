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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AccNumTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PinTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string[] accountnames = new string[20] { "Valencia, Rizalina", "Dapat, Rizal", "Maramot, Cloie", "Tan, Felnita", "Montenegro, Ma. Celia", "Macalintal, Connie", "Dela Cruz, Gloria", "Amoc, Gil Sherlock", "Fadri, Rodil", "Fernando, Aurora", "Campayan, Marie", "Temprosa, Hubert", "Mirabueno, Maria", "Tafalla, Karen", "Gumanay, Lyka", "Dela Cruz, Jocelyn", "Ranay, Ronald", "De Torres, Camille", "Lim, Anthony", "De Los Santos, Gabriel" };
            int[] accountnumber = new int[20] { 01112130, 01112131, 01112132, 01112133, 01112134, 01112135, 01112136, 01112137, 01112138, 01112139, 01112140, 01112141, 01112142, 01112143, 01112145, 01112146, 01112147, 01112148, 01112149, 01112150 };
            int[] pincode = new int[20] { 1010, 1020, 1030, 1040, 1050, 1060, 1070, 1080, 1090, 1000, 2000, 2010, 2020, 2030, 2050, 2060, 2070, 2080, 2090, 3000 };
            int pin = Convert.ToInt32(PinTextBox.Text);
            int acc = Convert.ToInt32(AccNumTextBox.Text);

            if (acc == accountnumber[0])
            {
                if (pin == pincode[0])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[0]);
                    name = accountnames[0];
                    Account = accountnumber[0];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[1])
            {
                if (pin == pincode[1])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[1]);
                    name = accountnames[1];
                    Account = accountnumber[1];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[2])
            {
                if (pin == pincode[2])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[2]);
                    name = accountnames[2];
                    Account = accountnumber[2];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[3])
            {
                if (pin == pincode[3])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[3]);
                    name = accountnames[3];
                    Account = accountnumber[3];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[4])
            {
                if (pin == pincode[4])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[4]);
                    name = accountnames[4];
                    Account = accountnumber[4];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[5])
            {
                if (pin == pincode[5])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[5]);
                    name = accountnames[5];
                    Account = accountnumber[5];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[6])
            {
                if (pin == pincode[6])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[6]);
                    name = accountnames[6];
                    Account = accountnumber[6];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[7])
            {
                if (pin == pincode[7])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[7]);
                    name = accountnames[7];
                    Account = accountnumber[7];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[8])
            {
                if (pin == pincode[8])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[8]);
                    name = accountnames[8];
                    Account = accountnumber[8];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[9])
            {
                if (pin == pincode[9])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[9]);
                    name = accountnames[9];
                    Account = accountnumber[9];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[10])
            {
                if (pin == pincode[10])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[10]);
                    name = accountnames[10];
                    Account = accountnumber[10];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[11])
            {
                if (pin == pincode[11])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[11]);
                    name = accountnames[11];
                    Account = accountnumber[11];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[12])
            {
                if (pin == pincode[12])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[12]);
                    name = accountnames[12];
                    Account = accountnumber[12];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[13])
            {
                if (pin == pincode[13])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[13]);
                    name = accountnames[13];
                    Account = accountnumber[13];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[14])
            {
                if (pin == pincode[14])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[14]);
                    name = accountnames[14];
                    Account = accountnumber[14];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[15])
            {
                if (pin == pincode[15])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[15]);
                    name = accountnames[15];
                    Account = accountnumber[15];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[16])
            {
                if (pin == pincode[16])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[16]);
                    name = accountnames[16];
                    Account = accountnumber[16];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[17])
            {
                if (pin == pincode[17])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[17]);
                    name = accountnames[17];
                    Account = accountnumber[17];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[18])
            {
                if (pin == pincode[18])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[18]);
                    name = accountnames[18];
                    Account = accountnumber[18];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (acc == accountnumber[19])
            {
                if (pin == pincode[19])
                {
                    MessageBox.Show("Welcome Mr./Mrs. " + accountnames[19]);
                    name = accountnames[19];
                    Account = accountnumber[19];
                    this.Hide();
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Pin or Account Number");
                }
            }
            if (accountnumber.Contains(acc) == false)
            {
                MessageBox.Show("Incorrect Pin or Account Number");
            }
        }
        public static string name = " ";
        public static int Account;
    }
}
