using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InventoryManagementSystem
{
    public static class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        // My Products section
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct(int productID)
        {
            var product = LookupProduct(productID);
            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }

        public static Product LookupProduct(int productID)
        {
            foreach (var product in Products)
            {
                if (product.ProductID == productID)
                    return product;
            }
            return null;
        }

        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = updatedProduct;
                    return;
                }
            }
        }

        // My Parts section
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool DeletePart(int partID)
        {
            var part = LookupPart(partID);
            if (part != null)
            {
                AllParts.Remove(part);
                return true;
            }
            return false;
        }

        public static Part LookupPart(int partID)
        {
            foreach (var part in AllParts)
            {
                if (part.PartID == partID)
                    return part;
            }
            return null;
        }

        public static void UpdatePart(int partID, Part updatedPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = updatedPart;
                    return;
                }
            }
        }
    }
}