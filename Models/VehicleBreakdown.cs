using System;
using System.Collections.Generic;

namespace serviceCar.Models.DbModels
{
    public partial class VehicleBreakdown
    {
        public int IdBreakdown { get; set; }
        public int IdVehicleBd { get; set; }
        public string Problem { get; set; }
        public string Description { get; set; }

        public virtual Vehicle IdVehicleBdNavigation { get; set; }
    }
}
