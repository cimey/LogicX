using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicX.DataLayer.Repository;
using LogicX.Model.Inputs.Coffee;

namespace LogicX.Service.Coffee
{
    public class CoffeeService : ICoffeeService
    {
        private IUnitOfWork _uow;

        /// <summary>
        /// this class will do database operations on UnitOfWork class
        /// UnitOfWork also should be registered to IOC container
        /// </summary>
        public CoffeeService()
        {
            _uow = new UnitOfWork();
        }
        public void CancelCoffeeOrderInput(CancelCoffeeOrderInput input)
        {
            throw new NotImplementedException();
        }

        public void DeleteCoffeeOrder(DeleteCoffeeOrderInput input)
        {
            throw new NotImplementedException();
        }

        public void OrderCoffee(OrderCoffeeInput input)
        {
            throw new NotImplementedException();
        }
    }
}
