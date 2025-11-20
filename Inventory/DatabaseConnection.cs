using MongoDB.Driver;
namespace Inventory
{
    public class DatabaseConnection
    {
        private IMongoDatabase mongoDb;
        public DatabaseConnection()
        {
            string url = "mongodb://localhost:27017";
            var client = new MongoClient(url);
            mongoDb = client.GetDatabase("InventoryDB");
        }

        public IMongoCollection<ProductsModel> GetProductsCollection()
        {
            // get the collection named product_inventory from the database
            return mongoDb.GetCollection<ProductsModel>("product_inventory");
        }

    }
}
