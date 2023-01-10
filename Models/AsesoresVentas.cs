namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AsesoresVentas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AsesoresVentas()
        {
            Reservas = new HashSet<Reservas>();
        }

        [Key]
        public int asesorId { get; set; }

        [Required]
        [StringLength(255)]
        public string nombreAsesor { get; set; }

        [Required]
        [StringLength(150)]
        public string email { get; set; }

        [Required]
        [StringLength(255)]
        public string telefono { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservas> Reservas { get; set; }
    }
}
