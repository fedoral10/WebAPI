namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Persona")]
    public partial class Persona
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Column(Order = 1)]
        [StringLength(200)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Direccion { get; set; }

        [StringLength(50)]
        public string Telefono { get; set; }

        [StringLength(50)]
        public string Cedula { get; set; }
    }
}
