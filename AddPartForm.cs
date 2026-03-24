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
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Min cannot be greater than Max");
                    return;
                }

                if (inventory < min || inventory > max)
                {
                    MessageBox.Show("Inventory must be between Min and Max");
                    return;
                }

                if (rbInHouse.Checked)
                {
                    int machineID = int.Parse(txtVariableField.Text.Trim());
                    InHouse newPart = new InHouse(Inventory.AllParts.Count + 1, name, price, inventory, min, max, machineID);
                    Inventory.AddPart(newPart);
                }
                else if (rbOutsourced.Checked)
                {
                    string companyName = txtVariableField.Text.Trim();
                    Outsourced newPart = new Outsourced(Inventory.AllParts.Count + 1, name, price, inventory, min, max, companyName);
                    Inventory.AddPart(newPart);
                }

                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in Inventory, Price, Max, Min, and Machine ID.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}