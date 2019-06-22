using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookingBossApi.Models
{
    public class BookingModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("timestamp")]
        public string TimeStamp { get; set; }
        [BsonElement("products")]
        public Product[] Products { get; set; }
    }

    public class Product{
        [BsonElement("id")]
        public long Id{ get; set; }
        [BsonElement("name")]
        public string Name{ get; set; }
        [BsonElement("quantity")]
        public int Quantity{ get; set; }
        [BsonElement("sale_amount")]
        public double Sale_amount{ get; set; }
    }
}
