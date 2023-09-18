using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBaiTap1
{
    public partial class Form1 : Form
    {
        private void txtYearOfBirth_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "this is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter your name ");
            else
                this.errorProvider1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you really want to close?", "Ex1",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter your name ");
            else
                this.errorProvider1.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is: " + txtYourName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtYearOfBirth.Text);
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYearOfBirth.Clear();
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
 