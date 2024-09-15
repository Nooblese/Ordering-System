using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4
{
    public partial class Form1 : Form
    {

        double item1 = 120.00;
        double item2 = 110.00;
        double item3 = 125.00;
        double item4 = 150.00;
        double item5 = 90.00;
        double item6 = 135.00;
        double item7 = 155.00;
        double item8 = 162.00;

        double MemDiscount = 50;
        double Togo = 10;
        double Total = 0;
        double MemTotal = 0;
        double points = 0.03;

        double price1 = 0, price2 = 0, price3 = 0, price4 = 0, price5 = 0, price6 = 0, price7 = 0, price8 = 0;

        //double Dprice1 = 0, Dprice2 = 0, Dprice3 = 0, Dprice4 = 0, Dprice5 = 0, Dprice6 = 0, Dprice7 = 0, Dprice8 = 0;

        double MemPoints;

        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown8.Enabled = false;
            numericUpDown7.Enabled = false;
            numericUpDown6.Enabled = false;
            numericUpDown5.Enabled = false;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (!chk1Latte.Checked && !chk2Brew.Checked && !chk3Brew.Checked && !chk4Latte.Checked && !chk5Coffee.Checked &&
                !chk6Macchiato.Checked && !chk7Frap.Checked && !chk8Frap.Checked)
            {
                MessageBox.Show("Please Choose an Item", "WOAH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown1.Value == 0 && numericUpDown2.Value == 0 && numericUpDown3.Value == 0 && numericUpDown4.Value == 0 && numericUpDown5.Value == 0
                 && numericUpDown6.Value == 0 && numericUpDown7.Value == 0 && numericUpDown8.Value == 0)
            {
                MessageBox.Show("Choose quantity", "WOAH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!rdoGo.Checked && !rdoHere.Checked) 
            {
                MessageBox.Show("Missing Entry for To go or Here", "WOAH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Total = price1 + price2 + price3 + price4 + price5 + price6 + price7 + price8;
                MemTotal = Total - MemDiscount;
                //MemTotal = Dprice1 + Dprice2 + Dprice3 + Dprice4 + Dprice5 + Dprice6 + Dprice7 + Dprice8;

                if (chkMember.Checked && rdoGo.Checked)
                {
                    //MemTotal = Dprice1 + Dprice2 + Dprice3 + Dprice4 + Dprice5 + Dprice6 + Dprice7 + Dprice8;
                    //MemTotal = MemTotal + Togo;
                    Total = MemTotal + Togo;
                    lblTotal.Text = Total.ToString();
                    MemPoints = Total * points;
                    lblPoints.Text = MemPoints.ToString();
                }
                else if (chkMember.Checked && rdoHere.Checked) 
                {
                    Total = MemTotal;
                    lblTotal.Text = Total.ToString();
                    MemPoints = Total * points;
                    lblPoints.Text = MemPoints.ToString();
                }
                else if(rdoGo.Checked)
                {
                    //Total = price1 + price2 + price3 + price4 + price5 + price6 + price7 + price8;
                    Total = Total + Togo;
                    lblTotal.Text = Total.ToString();
                    lblPoints.Text = "";
                }
                else 
                {
                    lblTotal.Text = Total.ToString();
                    lblPoints.Text = "";
                }
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            price1 = Convert.ToInt32(numericUpDown1.Value) * item1;
            //Dprice1 = price1 - MemDiscount;

        }

        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {
            price2 = Convert.ToInt32(numericUpDown2.Value) * item2;
            //Dprice2 = price2 - MemDiscount;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            price3 = Convert.ToInt32(numericUpDown3.Value) * item3;
            //Dprice3 = price3 - MemDiscount;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            price4 = Convert.ToInt32(numericUpDown4.Value) * item4;
            //Dprice4 = price4 - MemDiscount;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            price5 = Convert.ToInt32(numericUpDown5.Value) * item5;
            //Dprice5 = price5 - MemDiscount;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            price6 = Convert.ToInt32(numericUpDown6.Value) * item6;
            //Dprice6 = price6 - MemDiscount;
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            //price7 = Convert.ToInt32(numericUpDown7.Value) * item7;
            Dprice7 = price7 - MemDiscount;
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            price8 = Convert.ToInt32(numericUpDown8.Value) * item8;
            //Dprice8 = price8 - MemDiscount;
        }

        private void chk1Latte_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1Latte.Checked)
            {
                numericUpDown1.Enabled = true;
            }
            else
            {
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
            }
        }

        private void chk2Brew_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2Brew.Checked)
            {
                numericUpDown2.Enabled = true;
            }
            else
            {
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 0;
            }
        }


        private void chk3Brew_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3Brew.Checked)
            {
                numericUpDown3.Enabled = true;
            }
            else
            {
                numericUpDown3.Enabled = false;
                numericUpDown3.Value = 0;
            }
        }

        private void chk4Latte_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4Latte.Checked)
            {
                numericUpDown4.Enabled = true;
            }
            else
            {
                numericUpDown4.Enabled = false;
                numericUpDown4.Value = 0;
            }
        }

        private void chk5Coffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5Coffee.Checked)
            {
                numericUpDown5.Enabled = true;
            }
            else
            {
                numericUpDown5.Enabled = false;
                numericUpDown5.Value = 0;
            }
        }

        private void chk6Macchiato_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6Macchiato.Checked)
            {
                numericUpDown6.Enabled = true;
            }
            else
            {
                numericUpDown6.Enabled = false;
                numericUpDown6.Value = 0;
            }
        }

        private void chk7Frap_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7Frap.Checked)
            {
                numericUpDown7.Enabled = true;
            }
            else
            {
                numericUpDown7.Enabled = false;
                numericUpDown7.Value = 0;
            }
        }

        private void chk8Frap_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8Frap.Checked)
            {
                numericUpDown8.Enabled = true;
            }
            else
            {
                numericUpDown8.Enabled = false;
                numericUpDown8.Value = 0;
            }
        }
    }
}
