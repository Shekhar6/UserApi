using Microsoft.EntityFrameworkCore;

namespace UserApi.Model
{
    public class UserContextDb:DbContext
    {
        public UserContextDb(DbContextOptions<UserContextDb> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}
