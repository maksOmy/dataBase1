namespace WpfApp26
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemCatalogOfBook")]
    public partial class SystemCatalogOfBook
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SystemCatalogOfBook()
        {
            Books = new HashSet<Books>();
        }

        [Key]
        [StringLength(50)]
        public string CodeSpaceOfKnowledge { get; set; }

        [StringLength(40)]
        public string NameOfSpaceKnowledge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Books> Books { get; set; }
    }
}
