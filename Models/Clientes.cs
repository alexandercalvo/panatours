namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            Reservas = new HashSet<Reservas>();
            Vouchers = new HashSet<Vouchers>();
        }

        [Key]
        public int clienteId { get; set; }

        [Required]
        [StringLength(255)]
        public string cedula { get; set; }

        [Required]
        [StringLength(150)]
        public string clienteNombre { get; set; }

        [Required]
        [StringLength(150)]
        public string clienteApellido { get; set; }

        [Required]
        [StringLength(90)]
        public string clienteTelefono { get; set; }

        [Required]
        [StringLength(120)]
        public string clienteEmail { get; set; }

        [Required]
        [StringLength(250)]
        public string skuShopify { get; set; }

        public int tipoCliente { get; set; }

        public virtual TiposClientes TiposClientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservas> Reservas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vouchers> Vouchers { get; set; }
    }
}
