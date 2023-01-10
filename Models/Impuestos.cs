namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Impuestos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Impuestos()
        {
            ImpuestosProductos = new HashSet<ImpuestosProductos>();
            ReservasImpuestos = new HashSet<ReservasImpuestos>();
        }

        [Key]
        public int impuestoId { get; set; }

        public int tipoImpuesto { get; set; }

        [StringLength(150)]
        public string impuestoNombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImpuestosProductos> ImpuestosProductos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservasImpuestos> ReservasImpuestos { get; set; }
    }
}
