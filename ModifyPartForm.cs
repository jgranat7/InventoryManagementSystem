using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ModifyPartForm : Form
    {
        private Part partToModify;
        public ModifyPartForm(Part part)
        {
            InitializeComponent();
            partToModify = part;

            txtPartID.Text = part.PartID.ToString();
            txtPartName.Text = part.Name;
            txtPartInventory.Text = part.InStock.ToString();
            txtPartPrice.Text = part.Price.ToString();
            txtPartMax.Text = part.Max.ToString();
            txtPartMin.Text = part.Min.ToString();

            if (part is InHouse inHousePart)
            {
                rbInHouse.Checked = true;
                lblVariableField.Text = "Machine ID";
                txtVariableField.Text = inHousePart.MachineID.ToString();
            }
            else if (part is Outsourced outsourcedPart)
            {
                rbOutsourced.Checked = true;
                lblVariableField.Text = "Company Name";
                txtVariableField.Text = outsourcedPart.CompanyName;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblAddPartTitle_Click(object sender, EventArgs e)
        {

        }

        private void rbInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblVariableField.Text = "Machine ID";
        }

        private void rbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lblVariableField.Text = "Company Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtPartName.Text.Trim();
                int inventory = int.Parse(txtPartInventory.Text.Trim());
                decimal price = decimal.Parse(txtPartPrice.Text.Trim());
                int max = int.Parse(txtPartMax.Text.Trim());
                int min = int.Parse(txtPartMin.Text.Trim());

                if (min > max)
                {
                    MessageBox.Show("Min cannot be greater than Max.");
                    return;
                }

                if (inventory < min || inventory > max)
                {
                    MessageBox.Show("Inventory must be between Min and Max.");
                    return;
                }

                Part updatedPart;

                if (rbInHouse.Checked)
                {
                    int machineID = int.Parse(txtVariableField.Text.Trim());
                    updatedPart = new InHouse(partToModify.PartID, name, price, inventory, min, max, machineID);
                }
                else
                {
                    string companyName = txtVariableField.Text.Trim();
                    updatedPart = new Outsourced(partToModify.PartID, name, price, inventory, min, max, companyName);
                }

                Inventory.UpdatePart(partToModify.PartID, updatedPart);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values in all numeric fields.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {

        }
    }
}