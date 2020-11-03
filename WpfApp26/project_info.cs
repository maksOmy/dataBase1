namespace WpfApp26
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class project_info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public project_info()
        {
            worker_info1 = new HashSet<worker_info>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; }

        [Column(TypeName = "text")]
        public string ProjectName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProjectStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProjectStop { get; set; }

        [Column(TypeName = "text")]
        public string Chief { get; set; }

        [Column(TypeName = "int")]
        public int? BonusAll { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EmloyeeStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EmloyeeStop { get; set; }

        public int? CustomerID { get; set; }

        public int? WorkerID { get; set; }

        public virtual Customer_Inform Customer_Inform { get; set; }

        public virtual worker_info worker_info { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<worker_info> worker_info1 { get; set; }
    }
}
