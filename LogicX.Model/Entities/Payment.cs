using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicX.Model.Entities
{

    [Table("Payment")]
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public decimal Amaount { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public virtual ICollection<PaymentOrder> PaymentOrders { get; set; }
    }


    [Table("PaymentOrders")]
    public class PaymentOrder
    {
        public int Id { get; set; }

        public int PaymentId { get; set; }

        public int OrderId { get; set; }

        [ForeignKey("PaymentId")]
        public virtual Payment Payment { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}
