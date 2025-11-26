using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private ProductService productService;
        private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;
        private int _ProductId, _Quantity;
        private double _SellPrice;

        public frmAddProduct()
        {
            InitializeComponent();

        }

        public void ClearInput()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            cbCategory.SelectedIndex = -1;
            dtPickerMfgDate.Value = DateTime.Now;
            dtPickerExpDate.Value = DateTime.Now;
            txtSellPrice.Clear();
            txtQuantity.Clear();
            richTxtDescription.Clear();
        }

        public void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtProductId.Text))
                {
                    MessageBox.Show("Please input ProductID.", "Empty Product ID",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(txtProductId.Text.Trim(), @"^[0-9]"))
                {
                    MessageBox.Show("Please input the ProductID in numeric form", "Invalid Product ID",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //get values from input fields
                _ProductId = Convert.ToInt32(txtProductId.Text);
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.SelectedItem.ToString();
                _ManufacturingDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpirationDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                if (productService.FindProductbyId(_ProductId) != null)
                {
                    MessageBox.Show($"Product ID {_ProductId} already exists. Please use a different Product ID.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (string.IsNullOrWhiteSpace(_ProductName) ||
                    string.IsNullOrWhiteSpace(_Category) ||
                    string.IsNullOrWhiteSpace(_ManufacturingDate) ||
                    string.IsNullOrWhiteSpace(_ExpirationDate))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtPickerExpDate.Value <= dtPickerMfgDate.Value)
                {
                    MessageBox.Show("Expiration Date must be later than Manufacturing Date.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_Quantity <= 0)
                {
                    MessageBox.Show("Quantity cannot be negative.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_SellPrice < 0)
                {
                    MessageBox.Show("Selling Price cannot be negative.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ProductsModel newProduct = new ProductsModel
                {
                    ProductId = _ProductId,
                    ProductName = _ProductName,
                    Category = _Category,
                    ManufacturingDate = _ManufacturingDate,
                    ExpirationDate = _ExpirationDate,
                    Description = _Description,
                    Quantity = _Quantity,
                    SellPrice = _SellPrice
                };

                productService.AddProduct(newProduct);

                MessageBox.Show($"Product: {_ProductId} successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
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

        private void frmAddProduct_Load(object sender, EventArgs e)
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

            productService = new ProductService();

        }

        // custom exceptions
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
