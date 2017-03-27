using MongoDB.Bson;

namespace MongoDbMusic
{
    public class Album
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public int YearOfRelease { get; set; }
    }
}