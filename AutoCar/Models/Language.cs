namespace AutoCar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Language")]
    public partial class Language
    {
        public long Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }
    }
}
