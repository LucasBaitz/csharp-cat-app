using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class StarCat
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string ImageUrl { get; set; }
    public string Description { get; set; }

    public StarCat(string description, string imageUrl)
    {
        this.Description = description;
        this.ImageUrl = imageUrl;
    }
}
