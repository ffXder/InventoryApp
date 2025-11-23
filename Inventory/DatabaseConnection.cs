using MongoDB.Driver;
using DotNetEnv;
namespace Inventory
{
    public class DatabaseConnection
    {
        private IMongoDatabase mongoDb;
        public DatabaseConnection()
        {
            Env.Load();
            string url = Environment.GetEnvironmentVariable("MONGOATLAS_URI"); //to get the env variable
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
