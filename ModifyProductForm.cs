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
    public partial class ModifyProductForm : Form
    {
        private Product productToModify;
        private BindingList<Part> associatedParts = new BindingList<Part>();

        public ModifyProductForm(Product product)
        {
            InitializeComponent();
            productToModify = product;

            txtProductID.Text = product.ProductID.ToString();
            txtProductName.Text = product.Name;
            txtProductInventory.Text = product.InStock.ToString();
            txtProductPrice.Text = product.Price.ToString();
            txtProductMax.Text = product.Max.ToString();
            txtProductMin.Text = product.Min.ToString();

            dgvAllParts.DataSource = Inventory.AllParts;

            foreach (Part part in product.AssociatedParts)
            {
                associatedParts.Add(part);
            }
            dgvAssociatedParts.DataSource = associatedParts;

            txtProductID.ReadOnly = true;
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

                Product updatedProduct = new Product(productToModify.ProductID, name, price, inventory, min, max);

                foreach (Part part in associatedParts)
                {
                    updatedProduct.AddAssociatedPart(part);
                }

                Inventory.UpdateProduct(productToModify.ProductID, updatedProduct);

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