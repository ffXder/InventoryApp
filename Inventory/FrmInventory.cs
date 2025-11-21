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
            string objectId = "ObjectId ('" + txtFind.Text.Trim() + "')";
            ProductsModel product = productService.FindProductbyId(objectId);

            if (string.IsNullOrEmpty(objectId))
            {
                MessageBox.Show("Please enter a Product ID to search.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (product != null)
            {
                List<ProductsModel> productList = new List<ProductsModel> { product };
                gridViewProductList.DataSource = productList;
            }
            else
            {
                MessageBox.Show("Product not found.", "Search Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayProduct();
        }

    }
}
