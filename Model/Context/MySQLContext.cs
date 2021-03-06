<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;

namespace IntegraçãoBD.Model.Context
{
    public class MySQLContext : DbContext 
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){}

        public DbSet<Person> Persons { get; set; }
    }
}
=======
﻿using Microsoft.EntityFrameworkCore;

namespace IntegraçãoBD.Model.Context
{
    public class MySQLContext : DbContext 
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){}

        public DbSet<Person> Persons { get; set; }
    }
}
>>>>>>> b229451315734d9b753d51cf563749aeefb4c74f
