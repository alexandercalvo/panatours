namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pagos
    {
        [Key]
        public int pagoId { get; set; }

        [Required]
        [StringLength(255)]
        public string skuShopify { get; set; }

        [Column(TypeName = "numeric")]
        public decimal valor { get; set; }

        public int reservaId { get; set; }

        public virtual Reservas Reservas { get; set; }
    }
}
