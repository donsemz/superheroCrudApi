using Microsoft.EntityFrameworkCore;
using superheroCrudApi.Models;
using System.Collections.Generic;

namespace superheroCrudApi.Data
{
    public class SuperHeroDbContext: DbContext
    {
        public SuperHeroDbContext(DbContextOptions<SuperHeroDbContext> options) : base(options)
        {

        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
