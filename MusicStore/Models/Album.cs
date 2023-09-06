namespace MusicStore.Models
{
    public class Album
    {

        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public double Price { get; set; }
        public string AlbumArtUrl { get; set; }

        public ICollection<Song> Songs { get; set; }    
    }
}
