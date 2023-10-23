using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            builder.ToTable("Prenda");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasIndex(e => e.IdPrenda)
                    .IsUnique();

            builder.Property(e => e.Nombre)
                    .IsRequired();
            
            builder.Property(e => e.ValorUnitCOP)
                 .IsRequired()
                 .HasColumnType("double");

            builder.Property(e => e.ValorUnitUSD)
                    .IsRequired()
                    .HasColumnType("double");
            
            builder.HasOne(p => p.Estados)
                .WithMany(p => p.Prendas)
                .HasForeignKey(p => p.IdEstado);

            builder.HasOne(p => p.TiposProteccion)
                .WithMany(p => p.Prendas)
                .HasForeignKey(p => p.IdTipoProteccion);

            builder.HasOne(p => p.Generos)
                .WithMany(p => p.Prendas)
                .HasForeignKey(p => p.IdGenero);
        }
    }
}