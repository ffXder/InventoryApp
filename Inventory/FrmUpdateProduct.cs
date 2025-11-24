
using System.Text.RegularExpressions;

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
            try
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

                productUpdate.ProductName = Product_Name(txtProductName.Text);
                productUpdate.Category = cbCategory.Text;
                productUpdate.ManufacturingDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                productUpdate.ExpirationDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                productUpdate.Quantity = Quantity(txtQuantity.Text);
                productUpdate.SellPrice = SellingPrice(txtSellPrice.Text);
                productUpdate.Description = richTxtDescription.Text;


                productService.UpdateProduct(productUpdate);
                MessageBox.Show("Product updated successfully!", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (CurrencyFormatException cfEx)
            {
                MessageBox.Show(cfEx.Message, "CurrencyFormatException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NumberFormatException nfEx)
            {
                MessageBox.Show(nfEx.Message, "NumberFormatException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (StringFormatException SfEx)
            {
                MessageBox.Show(SfEx.Message, "StringFormatException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //custom exceptions
        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name.Trim(), @"^[a-zA-Z\s]+$"))
            {
                throw new StringFormatException("Product Name must contain only letters.");
            }
            return name;
        }
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
            {
                throw new NumberFormatException("Quantity must contain only numbers.");
            }
            return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
            {
                throw new CurrencyFormatException("Selling Price must be in currency format.");
            }

            return Convert.ToDouble(price);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
