using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestUdemy.Models.Context
{
    public class RestUdemyContext : DbContext
    {
        public RestUdemyContext() { }

        public RestUdemyContext(DbContextOptions<RestUdemyContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
    }
}
