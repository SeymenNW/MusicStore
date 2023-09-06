namespace MusicStore.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public ICollection<Playlist> Playlists { get; set;}
    }
}
