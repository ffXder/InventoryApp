using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private ProductService productService;
        private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;
        private int _ProductId , _Quantity;
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
                //get values from input fields
                _ProductId = Convert.ToInt32(txtProductId.Text);
                _ProductName = txtProductName.Text;
                _Category = cbCategory.SelectedItem?.ToString() ?? "";
                _ManufacturingDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpirationDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);


                ProductsModel newProduct = new ProductsModel
                {
                    ProductId = _ProductId ,
                    ProductName = _ProductName,
                    Category = _Category,
                    ManufacturingDate = _ManufacturingDate,
                    ExpirationDate = _ExpirationDate,
                    Description = _Description,
                    Quantity = _Quantity,
                    SellPrice = _SellPrice
                };


                productService.AddProduct(newProduct);


                MessageBox.Show($"Product {_ProductId} successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmInventory frmInventory = new FrmInventory();
                frmInventory.RefreshList();
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

            finally
            {
                Console.WriteLine("Product added successfully");
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

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
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


    }
}
