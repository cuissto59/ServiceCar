using System;
using System.Collections.Generic;

namespace serviceCar.Models.DbModels
{
    public partial class VehicleAccident
    {
        public int IdVehicleAc { get; set; }
        public string Type { get; set; }
        public string DamageDescription { get; set; }
        public bool? WasInsured { get; set; }
        public DateTime Date { get; set; }

        public virtual Vehicle IdVehicleAcNavigation { get; set; }
    }
}
