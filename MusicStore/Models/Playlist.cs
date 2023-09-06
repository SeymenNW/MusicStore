namespace MusicStore.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public ICollection<Song> Songs { get; set;}
    }
}
   