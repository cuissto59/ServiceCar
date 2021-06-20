using System;
using System.Collections.Generic;

namespace serviceCar.Models.DbModels
{
    public partial class VehicleSpending
    {
        public int IdSp { get; set; }
        public int IdVehicleSp { get; set; }
        public int IdConductorSp { get; set; }
        public DateTime DateSp { get; set; }
        public TimeSpan TimeSp { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }

        public virtual Conductor IdConductorSpNavigation { get; set; }
        public virtual Vehicle IdVehicleSpNavigation { get; set; }
        public virtual VehicleFuel VehicleFuel { get; set; }
    }
}
