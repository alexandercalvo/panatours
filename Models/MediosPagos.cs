namespace panatours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MediosPagos
    {
        [Key]
        public int medioDePagoId { get; set; }

        public int? medioDePagoNombre { get; set; }

        public int? parqueId { get; set; }
    }
}
