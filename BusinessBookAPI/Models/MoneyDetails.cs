using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BusinessBook;

public class MoneyDetails
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string? Investment { get; set; }

    public string? Income { get; set; }

    public string? Expense { get; set; }

    public string? Withdrawn { get; set; }

    public string? Balance { get; set; }
}

