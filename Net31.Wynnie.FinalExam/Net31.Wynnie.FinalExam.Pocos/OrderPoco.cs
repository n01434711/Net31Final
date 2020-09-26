using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Net31.Wynnie.FinalExam.Pocos
{
    [Table("Orders")]
    public class OrderPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("CustomerID")]
        public Guid CustomerID { get; set; }

        [Column("OrderDate")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Order Date can not be empty")]
        public DateTime OrderDate { get; set; }

        [Column("IsShipped")]
        public bool IsShipped { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("TimeStamp")]
        public byte[] TimeStamp { get; set; }

        public virtual CustomerPoco Customer { get; set; }

        public virtual ICollection<OrderProductPoco> OrderProducts { get; set; }
    }
}
