using LogicX.Model.Inputs.Coffee;
using LogicX.Service.Coffee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LogicX.API.Controllers
{
    [RoutePrefix("api/coffeeOrder")]
    public class CoffeeOrderController : ApiController
    {
        private ICoffeeService _coffeeService;

        public CoffeeOrderController()
        {
            _coffeeService = new CoffeeService();
        }

        [Route("OrderCoffee")]
        [HttpPost]
        public IHttpActionResult OrderCoffee(OrderCoffeeInput input)
        {
            _coffeeService.OrderCoffee(input);
            return Ok();
        }


        [Route("DeleteCoffeeOrder")]
        [HttpPost]
        public IHttpActionResult DeleteCoffeeOrder(DeleteCoffeeOrderInput input)
        {
            _coffeeService.DeleteCoffeeOrder(input);
            return Ok();
        }


        [Route("CancelCoffeeOrderInput")]
        [HttpPost]
        public IHttpActionResult CancelCoffeeOrderInput(CancelCoffeeOrderInput input)
        {
            _coffeeService.CancelCoffeeOrderInput(input);
            return Ok();
        }
    }
}
