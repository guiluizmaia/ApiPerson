using Microsoft.EntityFrameworkCore;

namespace IntegraçãoBD.Model.Context
{
    public class MySQLContext : DbContext 
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){}

        public DbSet<Person> Persons { get; set; }
        public DbSet<Books> Bookss { get; set; }
    }
}
