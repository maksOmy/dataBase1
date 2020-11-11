namespace WpfApp26
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InstanceOfBooks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InventoryNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string AvailabilityInLibrary { get; set; }

        [Column(TypeName = "date")]
        public DateTime TakedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        public int ReaderTicketNumber { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        public virtual Books Books { get; set; }

        public virtual Readers Readers { get; set; }
    }
}
