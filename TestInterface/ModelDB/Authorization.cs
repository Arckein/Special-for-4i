namespace TestInterface.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Authorization")]
    public partial class Authorization
    {
        [Key]
        [StringLength(15)]
        public string login { get; set; }

        [Required]
        [StringLength(8)]
        public string password { get; set; }
    }
}
