using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes; 

namespace Inventory
{
    // model class for products
    public class ProductsModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.Int32)]
        public int ProductId { get; set; }

        [BsonElement("productName")]
        public string ProductName { get; set; }

        [BsonElement("category")]
        public string Category { get; set; }

        [BsonElement("manufacturingDate")]
        public string ManufacturingDate { get; set; }

        [BsonElement("expirationDate")]
        public string ExpirationDate { get; set; }

        [BsonElement("sellingPrice")]
        public double SellPrice { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

    }
}
