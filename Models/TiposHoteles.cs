namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TiposHoteles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TiposHoteles()
        {
            Hoteles = new HashSet<Hoteles>();
        }

        [Key]
        public int tipoHotelId { get; set; }

        [Required]
        [StringLength(255)]
        public string tipoHotel { get; set; }

        [Required]
        [StringLength(255)]
        public string skuShopify { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoteles> Hoteles { get; set; }
    }
}
