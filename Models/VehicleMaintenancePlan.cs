using System;
using System.Collections.Generic;

namespace serviceCar.Models.DbModels
{
    public partial class VehicleMaintenancePlan
    {
        public int IdVehicleMp { get; set; }
        public string Description { get; set; }

        public virtual Vehicle IdVehicleMpNavigation { get; set; }
    }
}
