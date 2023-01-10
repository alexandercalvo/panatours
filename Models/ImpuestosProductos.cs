namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ImpuestosProductos
    {
        [Key]
        public int impuestoProductoId { get; set; }

        public int impuestoId { get; set; }

        public int productoId { get; set; }

        public virtual Impuestos Impuestos { get; set; }

        public virtual Productos Productos { get; set; }
    }
}
