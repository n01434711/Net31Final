using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Net31.Wynnie.FinalExam.Pocos
{
    [Table("OrderProducts")]
    public class OrderProductPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("OrderID")]
        public Guid OrderID { get; set; }

        [Column("ProductID")]
        public Guid ProductID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("TimeStamp")]
        public byte[] TimeStamp { get; set; }

        public virtual OrderPoco Order { get; set; }

        public virtual ProductPoco Product { get; set; }
    }
}
