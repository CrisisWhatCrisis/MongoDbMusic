using System.Linq;
using MongoDB.Driver;

namespace MongoDbMusic
{
    class Program
    {
        static void Main(string[] args)
        {
            var musicCtx = new MusicContext();

            var album = new Album{Artist = "Elton John", Name = "Yellow Brick Road", YearOfRelease = 1975};

            //musicCtx.Albums.InsertOne(album);

            var myAlbums = musicCtx.Albums. ere(x => x.YearOfRelease == 1975);

        }
    }
}
