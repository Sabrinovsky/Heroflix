using Heroflix.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heroflix.Controllers.Database
{
    public class HeroflixContext : DbContext
    {
        public HeroflixContext(DbContextOptions<HeroflixContext> options)
            :base(options){
            
        }

        public DbSet<Filme> Filmes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   modelBuilder.Entity<Filme>()
                .HasKey(f => f.Id);
            modelBuilder.Entity<Filme>()
                .Property(x => x.Titulo)
                .HasMaxLength(50);
            base.OnModelCreating(modelBuilder);
        }



}
}
