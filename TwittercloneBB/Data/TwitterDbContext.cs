using Microsoft.EntityFrameworkCore;
using TwittercloneBB.Models;
using Microsoft.Extensions.Configuration;
using Humanizer.Configuration;

namespace TwittercloneBB.Data
{
    public class TwitterDbContext : DbContext
    {
        public TwitterDbContext(DbContextOptions<TwitterDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<UserFollow> UserFollows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
    

}

