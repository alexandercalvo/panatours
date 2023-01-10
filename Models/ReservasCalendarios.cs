namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReservasCalendarios
    {
        [Key]
        public int reservaCalendarioId { get; set; }

        public int reservaId { get; set; }

        public int calendarioId { get; set; }

        public virtual Calendarios Calendarios { get; set; }

        public virtual Reservas Reservas { get; set; }
    }
}
