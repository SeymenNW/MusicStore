﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MusicStore.Models.Song>? Song { get; set; }
        public DbSet<MusicStore.Models.Album>? Album { get; set; }
        public DbSet<MusicStore.Models.Artist>? Artist { get; set; }

        public DbSet<MusicStore.Models.Playlist> Playlist { get; set; } = default!;
    }
}