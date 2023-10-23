using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class RopaAPIContext : DbContext
{
    public RopaAPIContext(DbContextOptions<RopaAPIContext> options) : base(options)
    {
    }

    public DbSet<Cargo> Cargos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Color> Colores { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<DetalleOrden> DetallesOrden { get; set; }
    public DbSet<DetalleVenta> DetallesVenta { get; set; }
    public DbSet<Empleado> Empleados { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}