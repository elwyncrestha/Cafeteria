using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class GenerateBill : Form
    {
        public GenerateBill()
        {
            InitializeComponent();
        }

        private void GenerateBill_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Varaible declaration
            double coffeePrice = 0;
            double teaPrice = 0;
            double momoPrice = 0;

            //manipulation part
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter your name !!!");
                txtName.Focus();
                return;
            }
            else {
                String customerName = txtName.Text;
            }

            if (txtCoffee.Text == "")
            {
                MessageBox.Show("Enter coffee price !!!");
                txtCoffee.Focus();
                return;
            }
            else
            {
                coffeePrice = double.Parse(txtCoffee.Text);
            }

            if (txtTea.Text == "")
            {
                MessageBox.Show("Enter tea price !!!");
                txtTea.Focus();
                return;
            }
            else
            {
                teaPrice = double.Parse(txtTea.Text);
            }

            if (txtMomo.Text == "")
            {
                MessageBox.Show("Enter momo price !!!");
                txtMomo.Focus();
                return;
            }
            else
            {
                momoPrice = double.Parse(txtMomo.Text);
            }

            //value sent to the Bill groupbox
            double totalPrice = coffeePrice + teaPrice + momoPrice;
            lblTotalAmount.Text = totalPrice.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            double discountAmount = 0;
            double vatAmount = 0;
            double netAmount = 0;
            double totalPrice = double.Parse(lblTotalAmount.Text);  //amount taken from label of another groupbox

            if (txtDiscountAmount.Text != "")
            {
                if (rdoFlat.Checked)
                {
                    //discount amount through price
                    discountAmount = double.Parse(txtDiscountAmount.Text);
                    if (discountAmount > totalPrice)
                    {
                        MessageBox.Show("Enter valid discount amount !!!");
                        txtDiscountAmount.Focus();
                        return;
                    }
                    else
                    {
                        totalPrice = totalPrice - discountAmount;
                    }
                }
                else if (rdoPercentage.Checked)
                {
                    //discount amount through rate
                    double discountRate = double.Parse(txtDiscountAmount.Text);   //discountRate
                    if (discountRate >= 0 && discountRate <= 100)
                    {
                        discountAmount = (discountRate / 100) * totalPrice;
                        totalPrice = totalPrice - discountAmount;
                    }
                    else
                    {
                        MessageBox.Show("Rate range: 0% - 100%");
                        txtDiscountAmount.Focus();
                        return;
                    }
                }
            }
            else {
                discountAmount = 0;
                totalPrice = double.Parse(lblTotalAmount.Text);
            }

            //Discount
            lblDiscountAmount.Text = discountAmount.ToString();

            //VAT
            vatAmount = (13f / 100) * totalPrice;
            lblVatAmount.Text = vatAmount.ToString();

            //NetAmount
            netAmount = totalPrice + vatAmount;
            lblNetAmount.Text = netAmount.ToString();
        }
    }
}
