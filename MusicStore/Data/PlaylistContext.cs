using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Data
{
    public class PlaylistContext : DbContext
    {
        public PlaylistContext (DbContextOptions<PlaylistContext> options)
            : base(options)
        {
        }

        public DbSet<MusicStore.Models.Playlist> Playlist { get; set; } = default!;
    }
}
