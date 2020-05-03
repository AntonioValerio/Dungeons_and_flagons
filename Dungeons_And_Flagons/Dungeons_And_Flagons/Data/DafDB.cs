

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dungeons_And_Flagons.Models;
using Microsoft.EntityFrameworkCore;

namespace Dungeons_And_Flagons.Data
{
    public class DafDB : DbContext
    {
        public DafDB(DbContextOptions<DafDB> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<SubclassSpell>().HasKey(table1 => new { table1.SubclassID, table1.SpellID });
            modelBuilder.Entity<ClasseSpells>().HasKey(table2 => new { table2.ClasseID, table2.SpellID });
           
            modelBuilder.Entity<Subclasses>().HasOne(s => s.Book).WithMany(s => s.Subclasses).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Classes>().HasOne(s => s.Book).WithMany(s => s.Classes).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Spells>().HasOne(s => s.Book).WithMany(s => s.Spells).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Subraces>().HasOne(s => s.Book).WithMany(s => s.Subraces).OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Classes> Classes { get; set; }
        public DbSet<ClasseSpells> ClasseSpells { get; set; }
        public DbSet<Sources> Sources { get; set; }
        public DbSet<Spells> Spells { get; set; }
        public DbSet<Subclasses> Subclasses { get; set; }
        public DbSet<SubclassSpell> SubclassSpell { get; set; }
        public DbSet<Subraces> Subraces { get; set; }
       


    }
}
