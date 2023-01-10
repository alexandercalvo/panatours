namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Temporadas
    {
        [Key]
        public int temporadaId { get; set; }

        [Required]
        [StringLength(150)]
        public string temporadaNombre { get; set; }

        [Required]
        [StringLength(255)]
        public string skuShopify { get; set; }

        public DateTime? temporadaFechaInicio { get; set; }

        public DateTime? temporadaFechaFinal { get; set; }
    }
}
