using LogicX.Model.Inputs.Coffee;
using LogicX.Service.ETA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LogicX.API.Controllers
{
    [RoutePrefix("api/eta")]
    public class ETAController : ApiController
    {
        private IETAService _etaService;

        public ETAController()
        {
            _etaService = new ETAService();
        }

        [Route("CalculateETA")]
        [HttpPost]
        public IHttpActionResult CalculateETA(CalculateETAInput input)
        {
            return Ok(_etaService.CalculateETA(input));
        }
    }
}
