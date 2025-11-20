using MongoDB.Driver;

namespace Inventory
{
    // service class that performs database operations 
    public class ProductService
    {
        private DatabaseConnection dbConnection;
        private BindingSource bindingSource;
        public ProductService() 
        { 
            dbConnection = new DatabaseConnection();
            bindingSource = new BindingSource();
        }

        public void AddProduct(ProductsModel product)
        {
            var productsCollection = dbConnection.GetProductsCollection();
            productsCollection.InsertOne(product);
        }

        public List<ProductsModel> GetAllProducts()
        {
            var productsCollection = dbConnection.GetProductsCollection();
            return productsCollection.Find(_ => true).ToList();
        }
    }
}
