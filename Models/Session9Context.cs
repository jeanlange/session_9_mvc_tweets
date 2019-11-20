using Microsoft.EntityFrameworkCore;

namespace s9tweets.Models{
    public class Session9Context : DbContext{
        public Session9Context(DbContextOptions<Session9Context> options) : base(options){

        }
        public DbSet<User> UserTable {get; set;}
        public DbSet<Tweet> TweetTable {get; set;}
    }

}