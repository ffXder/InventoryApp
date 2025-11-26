namespace Inventory
{
    public partial class FrmInventory : Form
    {
        private ProductService productService;
        public FrmInventory()
        {
            InitializeComponent();
            gridViewProductList.CellContentDoubleClick += gridViewProductList_CellContentClick; //register an event
        }
        private void FrmInventory_Load(object sender, EventArgs e)
        {
            productService = new ProductService();
            DisplayProduct();
        }

        public void RefreshList()
        {
            productService.ProductStatus();
            DisplayProduct();
        }

        public void DisplayProduct()
        {
            List<ProductsModel> products = productService.GetAllProducts();
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = products;
            TableIndicator();
        }

        //color indicator for low stock
        public void TableIndicator()
        {
            foreach (DataGridViewRow row in gridViewProductList.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                //DateTime exp = DateTime.Parse(row.Cells["ExpirationDate"].Value.ToString());

                if (quantity == 0 )
                {
                    // if the quantity is low it will indicate red
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                    row.Cells["Quantity"].Style.BackColor = Color.IndianRed;  

                }
                else if (quantity <= 5)
                {
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    row.Cells["Quantity"].Style.BackColor = Color.LightSalmon;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAddProduct = new frmAddProduct();
            frmAddProduct.ShowDialog();
            RefreshList();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtFind.Text.Trim(), out int objectId))
            {
                MessageBox.Show("Please enter a Product ID to search.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshList();
                return;
            }

            var findProduct = productService.FindProductbyId(objectId);

            if (findProduct != null)
            {
                gridViewProductList.DataSource = new List<ProductsModel> { findProduct };
            }
            else
            {
                MessageBox.Show("Product not found.", "Search Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshList();
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
                $"Are you sure you want to delete Product ID: {productId}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                productService.DeleteProduct(productId);
                MessageBox.Show("Product deleted successfully!");
                RefreshList();
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
                RefreshList(); // refreshes the table
            }
            else
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        //double click the cell to update 
        private void gridViewProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            int productId = Convert.ToInt32(gridViewProductList.Rows[e.RowIndex].Cells["ProductId"].Value);

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
            RefreshList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            List<ProductsModel> searchProduct = productService.SearchProduct(search);

            gridViewProductList.DataSource = searchProduct;

            TableIndicator();
        }


        private void btnStockIn_Click(object sender, EventArgs e)
        {
            if (gridViewProductList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to stock in.");
                return;
            }

            int productId = Convert.ToInt32(gridViewProductList.SelectedRows[0].Cells["ProductId"].Value);

            int currentQty = Convert.ToInt32(gridViewProductList.SelectedRows[0].Cells["Quantity"].Value);
            int addQty = (int)numStock.Value;

            int newQty = currentQty + addQty;
            productService.UpdateProductQuantity(productId, newQty);

            RefreshList();
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            if (gridViewProductList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to stock out.");
                return;
            }

            int productId = Convert.ToInt32(gridViewProductList.SelectedRows[0].Cells["ProductId"].Value);

            int currentQty = Convert.ToInt32(gridViewProductList.SelectedRows[0].Cells["Quantity"].Value);
            int subractQty = (int)numStock.Value;

            if (currentQty == 0)
            {
                MessageBox.Show("Cannot remove stock because there is no stock available", "No Available Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (subractQty > currentQty)
            {
                MessageBox.Show("Cannot remove stock because there is not enough stock", "Not Enough", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newQty = currentQty - subractQty;

            productService.UpdateProductQuantity(productId, newQty);

            RefreshList();
        }
        
        //close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Close Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
