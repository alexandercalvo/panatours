namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PagosDescuentos
    {
        [Key]
        public int pagoId { get; set; }

        public int descuentoId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal valor { get; set; }

        public virtual Descuentos Descuentos { get; set; }
    }
}
