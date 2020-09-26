using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net31.Wynnie.FinalExam.Pocos
{
    [Table("Customers")]
    public class CustomerPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Customer Name can not be empty")]
        public string Name { get; set; }

        [Column("Age")]
        [Range(18, 100, ErrorMessage = "age must be between 18 and 100")]
        public short Age { get; set; }

        [Column("Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Customer Address can not be empty")]
        public string Address { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("TimeStamp")]
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<OrderPoco> Orders { get; set; }
    }
}
