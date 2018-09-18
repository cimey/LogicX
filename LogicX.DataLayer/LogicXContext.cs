using LogicX.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicX.DataLayer
{
    public class LogicXContext : DbContext
    {
        public LogicXContext() : base()
        {
        }

        public DbSet<Alarm> AlarmSet { get; set; }
        public DbSet<Coffee> CoffeeSet { get; set; }
        public DbSet<Log> LogSet { get; set; }
        public DbSet<Order> OrderSet { get; set; }
        public DbSet<Payment> PaymentSet { get; set; }
        public DbSet<PaymentOrder> PaymentOrderSet { get; set; }
        public DbSet<User> UserSet { get; set; }
        public DbSet<Role> RoleSet { get; set; }
        public DbSet<UserRole> UserRoleSet { get; set; }


    }
}
