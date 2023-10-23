using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.ToTable("DetalleOrden");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasOne(p => p.Ordenes)
                 .WithMany(p => p.DetallesOrden)
                 .HasForeignKey(p => p.IdOrden);

            builder.HasOne(p => p.Prendas)
                .WithMany(p => p.DetallesOrden)
                .HasForeignKey(p => p.IdPrenda);

            builder.Property(e => e.CantidadProducir)
                 .HasColumnType("int");

            builder.HasOne(p => p.Colores)
                 .WithMany(p => p.DetallesOrden)
                 .HasForeignKey(p => p.IdColor);

            builder.Property(e => e.CantidadProducida)
                 .HasColumnType("int");

            builder.HasOne(p => p.Estados)
                 .WithMany(p => p.DetallesOrden)
                 .HasForeignKey(p => p.IdEstado);
        }
    }
}