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

        // display operation
        public List<ProductsModel> GetAllProducts()
        {
            var productsCollection = dbConnection.GetProductsCollection();
            return productsCollection.Find(_ => true).ToList();
        }

        // search
        public ProductsModel FindProductbyId(int Id)
        {
            var productsCollection = dbConnection.GetProductsCollection();
            var filterSearch = Builders<ProductsModel>.Filter.Eq(x => x.ProductId, Id);
            return productsCollection.Find(filterSearch).FirstOrDefault();
        }
        
        // update operation
       
       

        // delete operation
        public void DeleteProduct(int Id)
        {
            var productsCollection = dbConnection.GetProductsCollection();
            var filterDelete = Builders<ProductsModel>.Filter.Eq(x => x.ProductId, Id);
            productsCollection.DeleteOne(filterDelete);
        }
    }
}
