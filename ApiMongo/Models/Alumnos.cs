using MongoDB.Bson.Serialization.Attributes;

namespace ApiMongo.Models
{
    public class Alumnos
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("nombre")]
        public string Nombre { get; set; }
        [BsonElement("edad")]
        public int Edad { get; set; }

    }
}
