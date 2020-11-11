namespace WpfApp26
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Books()
        {
            InstanceOfBooks = new HashSet<InstanceOfBooks>();
            SystemCatalogOfBook = new HashSet<SystemCatalogOfBook>();
        }

        [Key]
        [StringLength(13)]
        public string ISBN { get; set; }

        [Required]
        [StringLength(150)]
        public string NameOfBook { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string AutorOfBook { get; set; }

        [Required]
        [StringLength(50)]
        public string PublisherOfBook { get; set; }

        [StringLength(50)]
        public string PublicPlaceOfBook { get; set; }

        public int PublicYearOfBook { get; set; }

        public int PageCountOfBook { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstanceOfBooks> InstanceOfBooks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemCatalogOfBook> SystemCatalogOfBook { get; set; }
    }
}
