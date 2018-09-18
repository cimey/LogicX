using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicX.Model.Entities
{

    public enum OrderStatus : short
    {
        PreOrdered = 1,
        Preparing = 2,
        Ready = 3,
        Delivered = 4,
        Cancelled = 5
    }

    public enum OrderPlatform : short
    {
        Mobile = 1,
        Web = 2,
        Shop = 3
    }
    [Table("Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    
        [Required]
        public int CoffeeId { get; set; }

        [Required]
        public DateTime PickupTime { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public OrderStatus OrderStatus { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public OrderPlatform OrderPlatform { get; set; }

        [ForeignKey("CoffeeId")]
        public virtual Coffee Coffee { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public virtual ICollection<PaymentOrder> PaymentOrders { get; set; }
    }
}
