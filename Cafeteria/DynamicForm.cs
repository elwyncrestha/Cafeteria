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
    public partial class DynamicForm : Form
    {
        private float momoPrice = 100f;
        private float chowmeinPrice = 80f;
        private float pizzaPrice = 250f;
        private float cokePrice = 30f;
        private float grandTotalPrice = 0f;

        public DynamicForm()
        {
            InitializeComponent();
        }

        //public static float calGraTotal(List<float> lstTotal) {
        //    float grandTotalPrice = 0f;
        //    for (int index1 = 0; index1 < lstTotal.Items.Count; index1++)
        //    {
        //        float tPrice = (float)lstTotal.Items[index1];
        //        grandTotalPrice = grandTotalPrice + tPrice;
        //    }
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtNoItems.Text == "")                           //Nullable validation
            {
                MessageBox.Show("Enter number of items !!!");
                txtNoItems.Focus();
                return;
            }
            else {
                int itemsNumber = int.Parse(txtNoItems.Text);
                if (itemsNumber < 1)                            //item number validation
                {
                    MessageBox.Show("Enter valid number of items !!!");
                    txtNoItems.Focus();
                }
                else {                                          //correct flow  
                    float totalPrice = 0f;

                    lstItem.Items.Add(cboItem.Text);            //item name added
                    lstQty.Items.Add(itemsNumber);              //quantity added
                    
                    if (cboItem.Text == "Momo")
                    {
                        lstPrice.Items.Add(momoPrice);          //price added
                        totalPrice = itemsNumber * momoPrice;
                        lstTotal.Items.Add(totalPrice);
                        grandTotalPrice = 0;
                        for (int index1 = 0; index1 < lstTotal.Items.Count; index1++)
                        {
                            float tPrice = (float)lstTotal.Items[index1];
                            grandTotalPrice = grandTotalPrice + tPrice;
                        }
                    }
                    else if (cboItem.Text == "Pizza")
                    {
                        lstPrice.Items.Add(pizzaPrice);         //price added
                        totalPrice = itemsNumber * pizzaPrice;
                        lstTotal.Items.Add(totalPrice);
                        grandTotalPrice = 0;
                        for (int index1 = 0; index1 < lstTotal.Items.Count; index1++)
                        {
                            float tPrice = (float)lstTotal.Items[index1];
                            grandTotalPrice = grandTotalPrice + tPrice;
                        }
                    }
                    else if (cboItem.Text == "Chowmein")
                    {
                        lstPrice.Items.Add(chowmeinPrice);       //price added
                        totalPrice = itemsNumber * chowmeinPrice;
                        lstTotal.Items.Add(totalPrice);
                        grandTotalPrice = 0;
                        for (int index1 = 0; index1 < lstTotal.Items.Count; index1++)
                        {
                            float tPrice = (float)lstTotal.Items[index1];
                            grandTotalPrice = grandTotalPrice + tPrice;
                        }
                    }
                    else if (cboItem.Text == "Coke")
                    {
                        lstPrice.Items.Add(cokePrice);          //price added
                        totalPrice = itemsNumber * cokePrice;
                        lstTotal.Items.Add(totalPrice);
                        grandTotalPrice = 0;
                        for (int index1 = 0; index1 < lstTotal.Items.Count; index1++)
                        {
                            float tPrice = (float)lstTotal.Items[index1];
                            grandTotalPrice = grandTotalPrice + tPrice;
                        }
                    }
                }

                lblGrandTotal.Text = grandTotalPrice.ToString();
                txtNoItems.Text = "";                           //noOfItem will reset
            }
        }

        private void lstItem_Keydown(object sender, KeyEventArgs e)
        {
            int index = 0;
            if (e.KeyCode == Keys.Delete) {
                DialogResult msg = MessageBox.Show("Are you sure you want to delete ?","Delete",MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes && lstItem.Text == "Momo") {
                    index = lstItem.SelectedIndex;
                    lstItem.Items.RemoveAt(index);
                    lstQty.Items.RemoveAt(index);
                    lstPrice.Items.RemoveAt(index);
                    lstTotal.Items.RemoveAt(index);
                    grandTotalPrice = 0;
                    for (int index1 = 0; index1 < lstTotal.Items.Count; index1++)
                    {
                        float tPrice = (float)lstTotal.Items[index1];
                        grandTotalPrice = grandTotalPrice + tPrice;
                    }
                }
                else if (msg == DialogResult.Yes && lstItem.Text == "Pizza")
                {
                    index = lstItem.SelectedIndex;
                    lstItem.Items.RemoveAt(index);
                    lstQty.Items.RemoveAt(index);
                    lstPrice.Items.RemoveAt(index);
                    lstTotal.Items.RemoveAt(index);
                    grandTotalPrice = 0;
                    for (int index1 = 0; index1 < lstTotal.Items.Count; index1++)
                    {
                        float tPrice = (float)lstTotal.Items[index1];
                        grandTotalPrice = grandTotalPrice + tPrice;
                    }
                }
                else if (msg == DialogResult.Yes && lstItem.Text == "Chowmein")
                {
                    index = lstItem.SelectedIndex;
                    lstItem.Items.RemoveAt(index);
                    lstQty.Items.RemoveAt(index);
                    lstPrice.Items.RemoveAt(index);
                    lstTotal.Items.RemoveAt(index);
                    grandTotalPrice = 0;
                    for (int index1 = 0; index1 < lstTotal.Items.Count; index1++)
                    {
                        float tPrice = (float)lstTotal.Items[index1];
                        grandTotalPrice = grandTotalPrice + tPrice;
                    }
                }
                else if (msg == DialogResult.Yes && lstItem.Text == "Coke")
                {
                    index = lstItem.SelectedIndex;
                    lstItem.Items.RemoveAt(index);
                    lstQty.Items.RemoveAt(index);
                    lstPrice.Items.RemoveAt(index);
                    lstTotal.Items.RemoveAt(index);
                    grandTotalPrice = 0;
                    for (int index1 = 0; index1 < lstTotal.Items.Count; index1++)
                    {
                        float tPrice = (float)lstTotal.Items[index1];
                        grandTotalPrice = grandTotalPrice + tPrice;
                    }
                }
                lblGrandTotal.Text = grandTotalPrice.ToString();
            }
        }
    }
}
