namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vouchers
    {
        [Key]
        public int voucherId { get; set; }

        [Required]
        [StringLength(64)]
        public string voucherNumero { get; set; }

        public DateTime fechaEmision { get; set; }

        [Required]
        public string observacion { get; set; }

        public int clienteId { get; set; }

        public int? reservaId { get; set; }

        public virtual Clientes Clientes { get; set; }

        public virtual Reservas Reservas { get; set; }
    }
}
