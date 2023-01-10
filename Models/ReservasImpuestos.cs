namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReservasImpuestos
    {
        [Key]
        public int reservaImpuestoId { get; set; }

        public int? impuestoId { get; set; }

        public int? reservaId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? valor { get; set; }

        public virtual Impuestos Impuestos { get; set; }

        public virtual Reservas Reservas { get; set; }
    }
}
