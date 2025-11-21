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
        public ProductsModel FindProductbyId(int Id)
        {
            var productsCollection = dbConnection.GetProductsCollection();
            var filterSearch = Builders<ProductsModel>.Filter.Eq(x => x.ProductId, Id);
            return productsCollection.Find(filterSearch).FirstOrDefault();
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
       

        // delete operation
        public void DeleteProduct(int Id)
        {
            var productsCollection = dbConnection.GetProductsCollection();
            var filterDelete = Builders<ProductsModel>.Filter.Eq(x => x.ProductId, Id);
            productsCollection.DeleteOne(filterDelete);
        }
    }
}
