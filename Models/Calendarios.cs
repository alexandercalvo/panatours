namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Calendarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Calendarios()
        {
            ReservasCalendarios = new HashSet<ReservasCalendarios>();
            Hoteles = new HashSet<Hoteles>();
        }

        [Key]
        public int calendarioId { get; set; }

        [Required]
        [StringLength(255)]
        public string calendarioIdApi { get; set; }

        public int tipoCalendarioId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservasCalendarios> ReservasCalendarios { get; set; }

        public virtual TiposCalendarios TiposCalendarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoteles> Hoteles { get; set; }
    }
}
