//Patrik Sullivan psullivan8@cnm.edu
//Store With Properties and Constructor
//6-15-20

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SullivanLogoStore
{
    public partial class LogoItemOrderForm : Form
    {
        public LogoItemOrderForm()
        {
            InitializeComponent();
        }

        private void txtOrderNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbUSB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMug_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbxLogo_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbxLogo.Checked)
            {
                lblColor.Visible = true;
                txtNumColors.Visible = true;
            }
        }

        private void txtSummary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumColors_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEngrave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEngrave.Text = "";
            txtNumColors.Text = "";
            txtNumItems.Text = "";
            txtOrderNum.Text = "";
            txtSummary.Text = "";
            ckbxLogo.Checked = false;
            rbMug.Checked = false;
            rbPen.Checked = false;
            rbUSB.Checked = false;
            lblColor.Visible = false;
            txtNumColors.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaring local variables
                bool hasLogo = false;
                string engraveText = "";
                //Instantiate logo order
                LogoOrderItem order = new LogoOrderItem(engraveText, hasLogo);
                //Getting order number
                order.ItemId = int.Parse(txtOrderNum.Text);
                //Getting number of items
                order.NumItems = int.Parse(txtNumItems.Text);
                //Checking which item is selected
                if (rbUSB.Checked == true) order.ItemType = "USB";
                else if (rbPen.Checked == true) order.ItemType = "Pen";
                else if (rbMug.Checked == true) order.ItemType = "Mug";
                if (ckbxLogo.Checked == true)
                {
                    order.HasLogo = true;
                }
                if(ckbxLogo.Checked == false)
                {
                    order.NumColors = 0;
                }
                if (!string.IsNullOrEmpty(txtEngrave.Text))
                {
                    order.EngraveText = txtEngrave.Text;
                }
                if (!string.IsNullOrEmpty(txtNumColors.Text))
                {
                    order.NumColors = int.Parse(txtNumColors.Text);
                }
                if (order.NumItems == 0)
                {
                    txtSummary.Text = "You must purchase at least one item.";
                }
                if (order.NumItems != 0)
                {
                    txtSummary.Text = order.GetOrderSummary();
                }
            }
            catch (Exception ex)
            {
                txtSummary.Text = (string.Format("An error occured in your order: {0}", ex.Message));
            }
        }
    }
}
