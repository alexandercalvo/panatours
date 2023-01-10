namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReservasProductos
    {
        [Key]
        public int productoReservaId { get; set; }

        public int productoId { get; set; }

        public int reservaId { get; set; }

        public virtual Productos Productos { get; set; }

        public virtual Reservas Reservas { get; set; }
    }
}
