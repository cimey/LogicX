using System;
using System.Collections.Generic;
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

    public enum PlatformEnum : short
    {
        Mobile = 1,
        Web = 2,
        Shop = 3
    }
    [Table("Order")]
    public class Order
    {

        public int Id { get; set; }

        public int CoffeeId { get; set; }

        public DateTime PickupTime { get; set; }

        public int UserId { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }
}
