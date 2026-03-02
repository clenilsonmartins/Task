using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domains;

namespace Task.Infra
{
    public class AppDContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }
        public AppDContext(DbContextOptions<AppDContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Titulo).IsRequired().HasMaxLength(150);
                entity.Property(e => e.Descricao).HasMaxLength(500);
                entity.Property(e => e.Status).IsRequired();
                entity.Property(e => e.Responsavel).IsRequired().HasMaxLength(150);
            });
        }
    }
}
