using MongoDB.Driver;

namespace MongoDbMusic
{
    public class MusicContext
    {
        private readonly IMongoDatabase _db;

        public MusicContext()
        {
            var mongoClient = new MongoClient();
            _db = mongoClient.GetDatabase("MyMusic");
        }

        public IMongoCollection<Album> Albums => _db.GetCollection<Album>("Albums");
    }
}