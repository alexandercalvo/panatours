namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            ImpuestosProductos = new HashSet<ImpuestosProductos>();
            ReservasProductos = new HashSet<ReservasProductos>();
            TarifasIniciales = new HashSet<TarifasIniciales>();
        }

        [Key]
        public int productoId { get; set; }

        [Required]
        [StringLength(120)]
        public string productoNombre { get; set; }

        public string productoDescripcion { get; set; }

        [Required]
        [StringLength(255)]
        public string skuShopify { get; set; }

        public int acomodacionId { get; set; }

        public int? hotelId { get; set; }

        public virtual Acomodaciones Acomodaciones { get; set; }

        public virtual Hoteles Hoteles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImpuestosProductos> ImpuestosProductos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservasProductos> ReservasProductos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarifasIniciales> TarifasIniciales { get; set; }
    }
}
