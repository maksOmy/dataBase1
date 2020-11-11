namespace WpfApp26
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Readers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Readers()
        {
            InstanceOfBooks = new HashSet<InstanceOfBooks>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReaderTicketNumber { get; set; }

        [Column(TypeName = "text")]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirthday { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Adress { get; set; }

        public int HomePhoneNumber { get; set; }

        public int? WorkPhoneNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstanceOfBooks> InstanceOfBooks { get; set; }
    }
}
