
namespace Inventory
{
    public partial class FrmUpdateProduct : Form
    {
        private ProductsModel productUpdate;
        private ProductService productService;
        public FrmUpdateProduct(ProductsModel products)
        {
            InitializeComponent();
            productUpdate = products;
            productService = new ProductService();
            //txtProductId.Enabled = false;
            txtProductId.Text = productUpdate.ProductId.ToString();
            txtProductName.Text = productUpdate.ProductName.ToString();
            cbCategory.Text = productUpdate.Category;
            dtPickerMfgDate.Value = DateTime.Parse(productUpdate.ManufacturingDate.ToString());
            dtPickerExpDate.Value = DateTime.Parse(productUpdate.ExpirationDate.ToString());
            txtQuantity.Text = productUpdate.Quantity.ToString();
            txtSellPrice.Text = productUpdate.SellPrice.ToString();
            richTxtDescription.Text = productUpdate.Description;
        }

        private void FrmUpdateProduct_Load(object sender, EventArgs e)
        {
            String[] ListOfProductCategory =
            {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
            };

            cbCategory.Items.AddRange(ListOfProductCategory);

        }
        
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(cbCategory.Text) ||
                string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtSellPrice.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtPickerExpDate.Value <= dtPickerMfgDate.Value)
            {
                MessageBox.Show("Expiration Date must be later than Manufacturing Date.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            productUpdate.ProductName = txtProductName.Text;
            productUpdate.Category = cbCategory.Text;
            productUpdate.ManufacturingDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
            productUpdate.ExpirationDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
            productUpdate.Quantity = int.Parse(txtQuantity.Text);
            productUpdate.SellPrice = double.Parse(txtSellPrice.Text);
            productUpdate.Description = richTxtDescription.Text;


            productService.UpdateProduct(productUpdate);
            MessageBox.Show("Product updated successfully!", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
