using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class FrmInventory : Form
    {
        private ProductService productService;
        public FrmInventory()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
            List<ProductsModel> products = productService.GetAllProducts();
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = products;
        }

        public void DisplayProduct()
        {
            List<ProductsModel> products = productService.GetAllProducts();
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = products;

        }
        private void FrmInventory_Load(object sender, EventArgs e)
        {
            productService = new ProductService();
            DisplayProduct();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAddProduct = new frmAddProduct();
            frmAddProduct.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int objectId = Convert.ToInt32(txtFind.Text);
            var findProduct = productService.FindProductbyId(objectId);

            if (objectId == 0)
            {
                MessageBox.Show("Please enter a Product ID to search.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (findProduct != null)
            {
                gridViewProductList.DataSource = new List<ProductsModel> { findProduct };
            }
            else
            {
                MessageBox.Show("Product not found.", "Search Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (gridViewProductList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            int productId = Convert.ToInt32(gridViewProductList.SelectedRows[0].Cells["ProductId"].Value);

            // Confirmation
            var confirm = MessageBox.Show(
                $"Are you sure you want to delete Product ID {productId}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                productService.DeleteProduct(productId);
                MessageBox.Show("Product deleted successfully!");
                DisplayProduct(); 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridViewProductList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            int productId = Convert.ToInt32(gridViewProductList.SelectedRows[0].Cells["ProductId"].Value);  

            ProductsModel product = productService.FindProductbyId(productId);

            if (product != null)
            {
                FrmUpdateProduct frmUpdateProduct = new FrmUpdateProduct(product);
                frmUpdateProduct.ShowDialog();
            }
            else
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayProduct();
        }

    }
}
