using LogicX.Model.Inputs.Coffee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicX.Service.ETA
{
    public interface IETAService
    {
        DateTime CalculateETA(CalculateETAInput input);
    }
}
