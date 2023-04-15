using MongoDB.Bson;
using MongoDB.Driver;

namespace CatApp.Database
{
    public class MongoDBConnection
    {
        private string connectionString = "mongodb://127.0.0.1:27017";
        private string databaseName = "CatApp";
        private string collectionName = "FavoriteCats";
        private IMongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<StarCat> collection;

        public MongoDBConnection()
        {
            client = new MongoClient(connectionString);
            db = client.GetDatabase(databaseName);
            collection = db.GetCollection<StarCat>(collectionName);
        }

        public async Task AddCat(StarCat cat)
        {
            await collection.InsertOneAsync(cat);
        }

        public async Task<List<StarCat>> GetFavCats()
        {
            var favCats = await collection.FindAsync(_ => true);
            var favCatsList = await favCats.ToListAsync();

            return favCatsList;
        }
    }
}