namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hoteles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hoteles()
        {
            Productos = new HashSet<Productos>();
            ReservasHoteles = new HashSet<ReservasHoteles>();
        }

        [Key]
        public int hotelId { get; set; }

        [Required]
        [StringLength(150)]
        public string hotelNombre { get; set; }

        [Required]
        [StringLength(255)]
        public string descripcion { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(100)]
        public string telefono { get; set; }

        [Required]
        [StringLength(100)]
        public string direccion { get; set; }

        public int tipoHotelId { get; set; }

        public int calendarioId { get; set; }

        public virtual Calendarios Calendarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos> Productos { get; set; }

        public virtual TiposHoteles TiposHoteles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservasHoteles> ReservasHoteles { get; set; }
    }
}
