namespace WpfApp26
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class worker_info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public worker_info()
        {
            project_info = new HashSet<project_info>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [Column(TypeName = "text")]
        public string EmpolyeeName { get; set; }

        [Column(TypeName = "text")]
        public string Address { get; set; }

        [Column(TypeName = "text")]
        public string District { get; set; }

        public int? Experience { get; set; }

        public int? Year { get; set; }

        [Column(TypeName = "text")]
        public string Language { get; set; }

        [Column(TypeName = "text")]
        public string Base { get; set; }

        public string Comment { get; set; }

        [Column(TypeName = "money")]
        public decimal? Salary { get; set; }

        [Column(TypeName = "money")]
        public decimal? Bonus { get; set; }

        [Column(TypeName = "money")]
        public decimal? GrossSalary { get; set; }

        [Column(TypeName = "money")]
        public decimal? Exempt { get; set; }

        [StringLength(10)]
        public string Picture { get; set; }

        public int? ProjectID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project_info> project_info { get; set; }

        public virtual project_info project_info1 { get; set; }
    }
}
