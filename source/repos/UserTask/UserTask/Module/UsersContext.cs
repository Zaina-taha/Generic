using Microsoft.EntityFrameworkCore;


namespace UserTask.Module
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions options) : base(options) { }
       public DbSet<Users> Users
        {
            get;
            set;
        }
        public DbSet<Posts> Posts
        {
            get;
            set;
        }

    }
}
