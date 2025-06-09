using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLX_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\lx 125.png ";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\s 125.png ";
        }

        private void btnPrimavera_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\primavera.png ";
        }

        private void btnSprint_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\sprint.png ";
        }

        private void btnGts_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\GTS.jpg ";
        }

        private void btnDragon_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\946.jpg ";
        }

        private void btnGtv_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\GTV.jpg ";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtSprint_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            double sprint = Convert.ToDouble(txtSprint.Text);
            double dragon = Convert.ToDouble(txtDragon.Text);
            double lx = Convert.ToDouble(txtLx.Text);
            double primavera = Convert.ToDouble(txtPrimavera.Text);
            double sum = sprint + dragon + lx + primavera;
            double discount = sum * 10.0/100.0;
            double vat = sum * 7.0 / 100.0;
            double pay = sum - discount + vat;

            lblAns.Text = "ราคารวม : " + sum.ToString() + "\n" 
                        + "ส่วนลด 10% " + discount.ToString() + "\n" 
                        + "Vat 7% " + vat.ToString() + "\n" 
                        + "รวมจ่ายเงิน " + pay.ToString() + "\n";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnKeep_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(txtName.Text);
            string surname = Convert.ToString(txtSurname.Text);
            lbl2.Text = name.ToString() + "  " + surname.ToString();
            lbl5.Text = "VESPA" + "\n" + "Member Card";

            if (radMan.Checked == true)
            {
                lbl3.Text = "เพศ " + radMan.Text;
            }
            else if (radWoman.Checked == true)
            {
                lbl3.Text = "เพศ " + radWoman.Text;
            }
            else 
            {
                lbl3.Text = "เพศ " + radLGBT.Text;
            }

            if (checkBox1.Checked == true)
            {
                lbl4.Text = "สถานะ " + checkBox1.Text;
            }
            else if (checkBox2.Checked == true)
            {
                lbl4.Text = "สถานะ " + checkBox2.Text;
            }
            else 
            {
                lbl4.Text = "สถานะ " + checkBox3.Text;
            }

            pictureBox6.ImageLocation = Application.StartupPath + "\\แมว.jpg";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox4.Text == textBox3.Text)
            {
                tabControl1.SelectedTab = tapPage2;
            }
            else
            {
                MessageBox.Show("Password and Confirm Password do not match. " +
                    "Please try again." , "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3 ;
        }
    }
}
