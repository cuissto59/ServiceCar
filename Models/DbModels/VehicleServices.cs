using System;
using System.Collections.Generic;

namespace serviceCar.Models.DbModels
{
    public partial class VehicleServices
    {
        public int IdVehicleSe { get; set; }
        public string Type { get; set; }
        public int Km { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Vehicle IdVehicleSeNavigation { get; set; }
    }
}
