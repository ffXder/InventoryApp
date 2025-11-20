using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private ProductService productService;
        private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;
        private int _Quantity;
        private double _SellPrice;
        
        public frmAddProduct()
        {
            InitializeComponent();

        }

        public void RefreshList()
        {
            List<ProductsModel> products = productService.GetAllProducts();
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = products;
        }

        public void ClearInput()
        {
            txtProductName.Clear();
            cbCategory.SelectedIndex = -1;
            dtPickerMfgDate.Value = DateTime.Now;
            dtPickerExpDate.Value = DateTime.Now;
            txtSellPrice.Clear();
            txtQuantity.Clear();
            richTxtDescription.Clear();
        }

        public void DisplayProducts()
        {
            productService.GetAllProducts();
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = productService;
        }

        public void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
               
                
                
                MessageBox.Show("Product successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                RefreshList();

                
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
            catch (StringFormatException sfEx)
            {
                MessageBox.Show(sfEx.Message, "StringFormatException", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            RefreshList();
        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                //Exception here
                throw new StringFormatException("Product Name must contain only letters.");
            }
                return name;
        }
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
            {
                //Exception here
                throw new NumberFormatException("Quantity must contain only numbers.");
            }
                return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
            {
                //Exception here
                throw new CurrencyFormatException("Selling Price must be in currency format.");
            }

            return Convert.ToDouble(price);
        }
    }
}
