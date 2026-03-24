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
    public partial class AddProductForm : Form
    {
        private BindingList<Part> associatedParts = new BindingList<Part>();

        public AddProductForm()
        {
            InitializeComponent();
            dgvAllParts.DataSource = Inventory.AllParts;
            dgvAssociatedParts.DataSource = associatedParts;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                associatedParts.Add(selectedPart);
            }
            else
            {
                MessageBox.Show("Please select a part to add.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtProductName.Text.Trim();
                int inventory = int.Parse(txtProductInventory.Text.Trim());
                decimal price = decimal.Parse(txtProductPrice.Text.Trim());
                int max = int.Parse(txtProductMax.Text.Trim());
                int min = int.Parse(txtProductMin.Text.Trim());

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

                int productID = Inventory.Products.Count + 1;
                Product newProduct = new Product(productID, name, price, inventory, min, max);

                foreach (Part part in associatedParts)
                {
                    newProduct.AddAssociatedPart(part);
                }

                Inventory.AddProduct(newProduct);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in Inventory, Price, Max, and Min.");
            }
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                var confirm = MessageBox.Show(
                    "Are you sure you want to remove this part from the product?",
                    "Confirm Remove",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    associatedParts.Remove(selectedPart);
                }
            }
            else
            {
                MessageBox.Show("Please select a part to remove.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchParts.Text.Trim().ToLower();
            bool found = false;

            foreach (DataGridViewRow row in dgvAllParts.Rows)
            {
                if (row.DataBoundItem is Part part)
                {
                    if (part.Name.ToLower().Contains(searchText) || part.PartID.ToString() == searchText)
                    {
                        row.Selected = true;
                        dgvAllParts.FirstDisplayedScrollingRowIndex = row.Index;
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("No matching part found.");
            }
        }
    }
}