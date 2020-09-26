using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Net31.Wynnie.FinalExam.Pocos
{
    [Table("Products")]
    public class ProductPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("ProductName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Product Name can not be empty")]
        public string ProductName { get; set; }

        [Column("SerialNumber")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Product Serial Number can not be empty")]
        public Guid SerialNumber { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("TimeStamp")]
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<OrderProductPoco> OrderProducts { get; set; }
    }
}
