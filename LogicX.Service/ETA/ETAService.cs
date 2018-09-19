using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicX.Model.Inputs.Coffee;

namespace LogicX.Service.ETA
{
    public class ETAService : IETAService
    {

        private readonly double _coffeeShopLattitude;
        private readonly double _coffeeShopLongitude;

        public ETAService()
        {
            //A point in Rome
            _coffeeShopLattitude = 41.891038;
            _coffeeShopLongitude = 12.492016;
        }
        public DateTime CalculateETA(CalculateETAInput input)
        {
            var sCoord = new GeoCoordinate(input.Lattitude, input.Longitude);
            var eCoord = new GeoCoordinate(_coffeeShopLattitude, _coffeeShopLongitude);

            var distance = sCoord.GetDistanceTo(eCoord);

            //an average person walk 1.4 meters in one second
            //so if we divide distance to speed we get the time in seconds
            return DateTime.Now.AddSeconds(distance / 1.4);
        }
    }
}
