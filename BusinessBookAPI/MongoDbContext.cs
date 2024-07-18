using System;
using BusinessBook.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BusinessBook.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<MoneyDetails> MoneyDetail =>
            _database.GetCollection<MoneyDetails>("MoneyDetails");
    }
}

