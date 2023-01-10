namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservas()
        {
            Pagos = new HashSet<Pagos>();
            ReservasCalendarios = new HashSet<ReservasCalendarios>();
            ReservasProductos = new HashSet<ReservasProductos>();
            ReservasImpuestos = new HashSet<ReservasImpuestos>();
            ReservasHoteles = new HashSet<ReservasHoteles>();
            Vouchers = new HashSet<Vouchers>();
        }

        [Key]
        public int reservaId { get; set; }

        [Required]
        [StringLength(255)]
        public string skuShopify { get; set; }

        public decimal valor { get; set; }

        public int clienteId { get; set; }

        public int asesorVentasId { get; set; }

        public int estadoReserva { get; set; }

        public int numeroAdultos { get; set; }

        public int? NumeroNinos { get; set; }

        public DateTime? checkin { get; set; }

        public DateTime? checkout { get; set; }

        public virtual AsesoresVentas AsesoresVentas { get; set; }

        public virtual Clientes Clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos> Pagos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservasCalendarios> ReservasCalendarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservasProductos> ReservasProductos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservasImpuestos> ReservasImpuestos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservasHoteles> ReservasHoteles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vouchers> Vouchers { get; set; }
    }
}
