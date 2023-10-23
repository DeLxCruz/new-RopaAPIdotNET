using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
    {
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("InsumoProveedor");

            builder.HasKey(e => new { e.IdInsumo, e.IdProveedor });

            builder.HasOne(p => p.Insumos)
                .WithMany(p => p.InsumosProveedor)
                .HasForeignKey(p => p.IdInsumo);

            builder.HasOne(p => p.Proveedores)
                .WithMany(p => p.InsumosProveedor)
                .HasForeignKey(p => p.IdProveedor);
        }
    }
}