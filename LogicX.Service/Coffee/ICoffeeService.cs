using LogicX.Model.Inputs.Coffee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicX.Service.Coffee
{
    public interface ICoffeeService
    {
        void OrderCoffee(OrderCoffeeInput input);
        void DeleteCoffeeOrder(DeleteCoffeeOrderInput input);
        void CancelCoffeeOrderInput(CancelCoffeeOrderInput input); 
    }
}
