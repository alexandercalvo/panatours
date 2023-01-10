namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TarifasIniciales
    {
        [Key]
        public int tarifaId { get; set; }

        public int ProductosproductoId { get; set; }

        public virtual Productos Productos { get; set; }
    }
}
