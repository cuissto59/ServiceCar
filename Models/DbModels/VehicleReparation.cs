using System;
using System.Collections.Generic;

namespace serviceCar.Models.DbModels
{
    public partial class VehicleReparation
    {
        public int IdVehicleRe { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public virtual Vehicle IdVehicleReNavigation { get; set; }
    }
}
