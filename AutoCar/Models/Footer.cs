namespace AutoCar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Footer")]
    public partial class Footer
    {
        public long Id { get; set; }

        [Column(TypeName = "ntext")]
        public string Context { get; set; }

        public bool Status { get; set; }
    }
}
