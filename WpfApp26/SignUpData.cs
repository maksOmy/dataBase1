namespace WpfApp26
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SignUpData")]
    public partial class SignUpData
    {
        [Key]
        [StringLength(30)]
        public string Login { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }
    }
}
