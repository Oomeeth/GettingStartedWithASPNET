using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Getting_Started.Models;

namespace Getting_Started.Data
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> person { get; set; }

        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {

        }
    }
}
