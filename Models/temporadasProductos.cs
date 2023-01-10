namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temporadasProductos
    {
        [Key]
        public int temporadaProductoId { get; set; }

        public int temporadaId { get; set; }

        public int productoId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? precio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? precioBase { get; set; }
    }
}
