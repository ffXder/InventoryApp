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

    }
}
