using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace panatours.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Acomodaciones> Acomodaciones { get; set; }
        public virtual DbSet<AsesoresVentas> AsesoresVentas { get; set; }
        public virtual DbSet<Calendarios> Calendarios { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Descuentos> Descuentos { get; set; }
        public virtual DbSet<Hoteles> Hoteles { get; set; }
        public virtual DbSet<Impuestos> Impuestos { get; set; }
        public virtual DbSet<ImpuestosProductos> ImpuestosProductos { get; set; }
        public virtual DbSet<MediosPagos> MediosPagos { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<PagosDescuentos> PagosDescuentos { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Reservas> Reservas { get; set; }
        public virtual DbSet<Reservas_Hoteles> Reservas_Hoteles { get; set; }
        public virtual DbSet<ReservasCalendarios> ReservasCalendarios { get; set; }
        public virtual DbSet<ReservasHoteles> ReservasHoteles { get; set; }
        public virtual DbSet<ReservasImpuestos> ReservasImpuestos { get; set; }
        public virtual DbSet<ReservasProductos> ReservasProductos { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TarifasIniciales> TarifasIniciales { get; set; }
        public virtual DbSet<Temporadas> Temporadas { get; set; }
        public virtual DbSet<temporadasProductos> temporadasProductos { get; set; }
        public virtual DbSet<TiposCalendarios> TiposCalendarios { get; set; }
        public virtual DbSet<TiposClientes> TiposClientes { get; set; }
        public virtual DbSet<TiposHoteles> TiposHoteles { get; set; }
        public virtual DbSet<TiposImpuesto> TiposImpuesto { get; set; }
        public virtual DbSet<Vouchers> Vouchers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acomodaciones>()
                .HasMany(e => e.Productos)
                .WithRequired(e => e.Acomodaciones)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AsesoresVentas>()
                .HasMany(e => e.Reservas)
                .WithRequired(e => e.AsesoresVentas)
                .HasForeignKey(e => e.asesorVentasId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Calendarios>()
                .HasMany(e => e.ReservasCalendarios)
                .WithRequired(e => e.Calendarios)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Calendarios>()
                .HasMany(e => e.Hoteles)
                .WithRequired(e => e.Calendarios)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.Reservas)
                .WithRequired(e => e.Clientes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.Vouchers)
                .WithRequired(e => e.Clientes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Descuentos>()
                .HasMany(e => e.PagosDescuentos)
                .WithRequired(e => e.Descuentos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hoteles>()
                .HasMany(e => e.ReservasHoteles)
                .WithRequired(e => e.Hoteles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Impuestos>()
                .HasMany(e => e.ImpuestosProductos)
                .WithRequired(e => e.Impuestos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.valor)
                .HasPrecision(26, 6);

            modelBuilder.Entity<PagosDescuentos>()
                .Property(e => e.valor)
                .HasPrecision(26, 6);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.ImpuestosProductos)
                .WithRequired(e => e.Productos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.ReservasProductos)
                .WithRequired(e => e.Productos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.TarifasIniciales)
                .WithRequired(e => e.Productos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservas>()
                .Property(e => e.valor)
                .HasPrecision(26, 6);

            modelBuilder.Entity<Reservas>()
                .HasMany(e => e.Pagos)
                .WithRequired(e => e.Reservas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservas>()
                .HasMany(e => e.ReservasCalendarios)
                .WithRequired(e => e.Reservas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservas>()
                .HasMany(e => e.ReservasProductos)
                .WithRequired(e => e.Reservas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservas>()
                .HasMany(e => e.ReservasHoteles)
                .WithRequired(e => e.Reservas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReservasImpuestos>()
                .Property(e => e.valor)
                .HasPrecision(26, 6);

            modelBuilder.Entity<temporadasProductos>()
                .Property(e => e.precio)
                .HasPrecision(26, 6);

            modelBuilder.Entity<temporadasProductos>()
                .Property(e => e.precioBase)
                .HasPrecision(26, 6);

            modelBuilder.Entity<TiposCalendarios>()
                .HasMany(e => e.Calendarios)
                .WithRequired(e => e.TiposCalendarios)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TiposClientes>()
                .HasMany(e => e.Clientes)
                .WithRequired(e => e.TiposClientes)
                .HasForeignKey(e => e.tipoCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TiposHoteles>()
                .HasMany(e => e.Hoteles)
                .WithRequired(e => e.TiposHoteles)
                .WillCascadeOnDelete(false);
        }
    }
}
