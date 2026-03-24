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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            // Test Data is used from the GUI Mock up supporting document
            // Test Data - Parts
            Inventory.AddPart(new InHouse(0, "Wheel", 12.11m, 15, 5, 25, 100));
            Inventory.AddPart(new InHouse(1, "Pedal", 8.22m, 11, 5, 25, 101));
            Inventory.AddPart(new InHouse(2, "Chain", 8.33m, 12, 5, 25, 102));
            Inventory.AddPart(new InHouse(3, "Seat", 4.55m, 8, 2, 15, 103));

            // Test Data - Products
            Product redBike = new Product(0, "Red Bicycle", 11.44m, 15, 1, 25);
            Product yellowBike = new Product(1, "Yellow Bicycle", 9.66m, 19, 1, 20);
            Product blueBike = new Product(2, "Blue Bicycle", 12.77m, 5, 1, 25);

            // Test Data - Parts associated with products
            // Test Data - Blue bike can be deleted in testing because no associated products
            // Test Data - Wheel can be deleted for quick/easy testing because it is currently not listed as associated with any products
            redBike.AddAssociatedPart(Inventory.LookupPart(0)); // Wheel
            redBike.AddAssociatedPart(Inventory.LookupPart(1)); // Pedal

            yellowBike.AddAssociatedPart(Inventory.LookupPart(2)); // Chain

            Inventory.AddProduct(redBike);
            Inventory.AddProduct(yellowBike);
            Inventory.AddProduct(blueBike);

            // Bind to DataGridViews
            dgvParts.DataSource = Inventory.AllParts;
            dgvParts.Columns["InStock"].HeaderText = "Inventory";

            dgvProducts.DataSource = Inventory.Products;
            dgvProducts.Columns["InStock"].HeaderText = "Inventory";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.ShowDialog();
        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                ModifyPartForm modifyPartForm = new ModifyPartForm(selectedPart);
                modifyPartForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                foreach (Product product in Inventory.Products)
                {
                    foreach (Part part in product.AssociatedParts)
                    {
                        if (part.PartID == selectedPart.PartID)
                        {
                            MessageBox.Show("This part is associated with a product and cannot be deleted.");
                            return;
                        }
                    }
                }

                var confirm = MessageBox.Show(
                    "Are you sure you want to delete this part?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    Inventory.DeletePart(selectedPart.PartID);
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchParts.Text.Trim().ToLower();
            bool found = false;

            foreach (DataGridViewRow row in dgvParts.Rows)
            {
                if (row.DataBoundItem is Part part)
                {
                    if (part.Name.ToLower().Contains(searchText) || part.PartID.ToString() == searchText)
                    {
                        row.Selected = true;
                        dgvParts.FirstDisplayedScrollingRowIndex = row.Index;
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                ModifyProductForm modifyProductForm = new ModifyProductForm(selectedProduct);
                modifyProductForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                if (selectedProduct.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete a product that has associated parts.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    Inventory.RemoveProduct(selectedProduct.ProductID);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchProducts.Text.Trim().ToLower();
            bool found = false;

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.DataBoundItem is Product product)
                {
                    if (product.Name.ToLower().Contains(searchText) || product.ProductID.ToString() == searchText)
                    {
                        row.Selected = true;
                        dgvProducts.FirstDisplayedScrollingRowIndex = row.Index;
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("No matching product found.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}