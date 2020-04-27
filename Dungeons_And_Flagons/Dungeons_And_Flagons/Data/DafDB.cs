using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dungeons_And_Flagons.Models;

namespace Dungeons_And_Flagons.Data
{
    public class DafDB : DbContext
    {
        public DafDB(DbContextOptions<DafDB> options) : base(options) { }


        public DbSet<Classes> Classes { get; set; }
        public DbSet<Sources> Sources { get; set; }
        public DbSet<Spells> Spells { get; set; }
        public DbSet<Subclasses> Subclasses { get; set; }
        public DbSet<SubclassSpell> SubclassSpell { get; set; }
        public DbSet<Subraces> Subraces { get; set; }
       


    }
}
