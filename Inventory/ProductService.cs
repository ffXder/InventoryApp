using System.Text.RegularExpressions;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Inventory
{
    // service class that performs database operations 
    public class ProductService
    {
        private DatabaseConnection dbConnection;
        public ProductService() 
        { 
            dbConnection = new DatabaseConnection();
        }

        // insert operation
        public void AddProduct(ProductsModel product)
        {
            var productsCollection = dbConnection.GetProductsCollection();
            productsCollection.InsertOne(product);
        }

        public bool isProductIdExists(int productId)
        {
            var productsCollection = dbConnection.GetProductsCollection();
            var filter = Builders<ProductsModel>.Filter.Eq(x => x.ProductId, productId);
            
            return productsCollection.Find(filter).Any();
        }

        // display operation
        public List<ProductsModel> GetAllProducts()
        {
           try
            {
                var productsCollection = dbConnection.GetProductsCollection();
                return productsCollection.Find(_ => true).ToList();

            } catch (Exception e)
            {
                MessageBox.Show("Error retrieving products: " + e.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ProductsModel>();
            }
       
        }

        // search
        public ProductsModel FindProductbyId(int productId)
        {
            var productsCollection = dbConnection.GetProductsCollection();
            var filterSearch = Builders<ProductsModel>.Filter.Eq(x => x.ProductId, productId);
            return productsCollection.Find(filterSearch).FirstOrDefault();
        }
        
        public List<ProductsModel> SearchProduct(string search)
        {
            var productsCollection = dbConnection.GetProductsCollection(); 

            string safeSearch = Regex.Escape(search); // to avoid regex error when typing special characters

            var filterSearch = Builders<ProductsModel>.Filter.Regex(x => x.ProductName, new BsonRegularExpression(safeSearch, "i")); // regex to avoid case sensitive
            return productsCollection.Find(filterSearch).ToList();
        }

        // update operation
        public void UpdateProduct(ProductsModel updatedProduct)
        {
            var productsCollection = dbConnection.GetProductsCollection();
            var filterUpdate = Builders<ProductsModel>.Filter.Eq(x => x.ProductId, updatedProduct.ProductId);

            var update = Builders<ProductsModel>.Update
                .Set(x => x.ProductName, updatedProduct.ProductName)
                .Set(x => x.Category, updatedProduct.Category)
                .Set(x => x.ManufacturingDate, updatedProduct.ManufacturingDate)
                .Set(x => x.ExpirationDate, updatedProduct.ExpirationDate)
                .Set(x => x.SellPrice, updatedProduct.SellPrice)
                .Set(x => x.Quantity, updatedProduct.Quantity)
                .Set(x => x.Description, updatedProduct.Description);

            productsCollection.UpdateOne(filterUpdate, update);
        }
       
        public void UpdateProductQuantity(int productId, int newQuantity)
        {
            var productsCollection = dbConnection.GetProductsCollection();
            var filterUpdate = Builders<ProductsModel>.Filter.Eq(x => x.ProductId, productId);
            var update = Builders<ProductsModel>.Update
                .Set(x => x.Quantity, newQuantity);

            productsCollection.UpdateOne(filterUpdate, update);
        }

        public void ProductStatus()
        {
            var productsCollection = dbConnection.GetProductsCollection();
            var findAll = productsCollection.Find(_ => true).ToList();

            string status;

            foreach (var row in findAll)
            {

                if (row.Quantity == 0)
                {
                    status = "Out of Stock";
                } 
                else if (row.Quantity <= 5)
                {
                    status = "Low Stock";
                }
                else
                {
                    status = "Available";
                }

                var filterId = Builders<ProductsModel>.Filter.Eq(x => x.ProductId, row.ProductId);
                var setStatus = Builders<ProductsModel>.Update.Set(x => x.Status, status);

                productsCollection.UpdateOne(filterId, setStatus);
            }

        }

        // delete operation
        public void DeleteProduct(int productId)
        {
            var productsCollection = dbConnection.GetProductsCollection();
            var filterDelete = Builders<ProductsModel>.Filter.Eq(x => x.ProductId, productId);
            productsCollection.DeleteOne(filterDelete);
        }
    }
}
