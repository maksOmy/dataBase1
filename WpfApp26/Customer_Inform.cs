namespace WpfApp26
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer_Inform
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer_Inform()
        {
            project_info = new HashSet<project_info>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Column(TypeName = "text")]
        public string Customer { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        [Column(TypeName = "text")]
        public string Bank { get; set; }

        [Column(TypeName = "text")]
        public string Account { get; set; }

        public int? INN { get; set; }

        [Column(TypeName = "text")]
        public string AdressCust { get; set; }

        [Column(TypeName = "text")]
        public string FioWorker { get; set; }

        [StringLength(50)]
        public string PhoneWorker { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project_info> project_info { get; set; }
    }
}
