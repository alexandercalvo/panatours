namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TiposImpuesto")]
    public partial class TiposImpuesto
    {
        [Key]
        public int tipoImpuestoId { get; set; }

        [Required]
        [StringLength(100)]
        public string nombreTipoImpuesto { get; set; }
    }
}
