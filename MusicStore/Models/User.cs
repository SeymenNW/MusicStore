using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MusicStore.Models
{
    public class User:IdentityDbContext
    {
        public bool IsAdmin { get; set; }
    public ICollection<User> Users { get; set;} = new List<User>();


    public User()
    {     
    }
    }
}
