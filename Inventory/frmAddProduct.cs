using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;
        private int _Quantity;
        private double _SellPrice;
        BindingSource showProductList;
        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        public void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(cbCategory.Text) || string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtSellPrice.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.SelectedItem.ToString();
                _ManufacturingDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpirationDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);
                showProductList.Add(new ProductClass(_ProductName, _Category, _ManufacturingDate, _ExpirationDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
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

            foreach(string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }

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
