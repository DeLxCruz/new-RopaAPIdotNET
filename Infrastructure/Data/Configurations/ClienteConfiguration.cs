using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasIndex(e => e.IdCliente)
                .IsUnique();
            
            builder.Property(e => e.Nombre)
                .IsRequired();

            builder.HasOne(p => p.TiposPersona)
                 .WithMany(p => p.Clientes)
                 .HasForeignKey(p => p.IdTipoPersona);

            builder.Property(e => e.FechaRegistro)
                 .HasColumnType("date");

            builder.HasOne(p => p.Municipios)
                 .WithMany(p => p.Clientes)
                 .HasForeignKey(p => p.IdMuncipio);

            
        }
    }
}