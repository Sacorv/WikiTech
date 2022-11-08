using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MicroservicioWiki.Data.Entidades
{
    public partial class MicroservicioWikiContext : DbContext
    {
        public MicroservicioWikiContext()
        {
        }

        public MicroservicioWikiContext(DbContextOptions<MicroservicioWikiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articulo> Articulos { get; set; } = null!;
        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<Colaborador> Colaboradors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.; Database=MicroservicioWiki; Trusted_Connection=True; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.HasKey(e => e.IdArticulo);

                entity.ToTable("Articulo");

                entity.Property(e => e.IdArticulo).ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.ImagenPrincipal).HasMaxLength(300);

                entity.Property(e => e.Titulo).HasMaxLength(100);

                entity.HasOne(d => d.IdArticuloNavigation)
                    .WithOne(p => p.Articulo)
                    .HasForeignKey<Articulo>(d => d.IdArticulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Articulo_Categoria");

                entity.HasOne(d => d.IdArticulo1)
                    .WithOne(p => p.Articulo)
                    .HasForeignKey<Articulo>(d => d.IdArticulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Articulo_Colaborador");
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<Colaborador>(entity =>
            {
                entity.HasKey(e => e.IdColaborador);

                entity.ToTable("Colaborador");

                entity.Property(e => e.Apellido).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
