using System;
using System.Collections.Generic;

namespace serviceCar.Models.DbModels
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            VehicleBreakdown = new HashSet<VehicleBreakdown>();
            VehicleSpending = new HashSet<VehicleSpending>();
        }

        public int IdVehicle { get; set; }
        public int VehicleConductor { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public bool InUse { get; set; }

        public virtual Conductor VehicleConductorNavigation { get; set; }
        public virtual VehicleAccident VehicleAccident { get; set; }
        public virtual VehicleBuyContract VehicleBuyContract { get; set; }
        public virtual VehicleGeneralInfo VehicleGeneralInfo { get; set; }
        public virtual VehicleMaintenancePlan VehicleMaintenancePlan { get; set; }
        public virtual VehicleReparation VehicleReparation { get; set; }
        public virtual VehicleServices VehicleServices { get; set; }
        public virtual ICollection<VehicleBreakdown> VehicleBreakdown { get; set; }
        public virtual ICollection<VehicleSpending> VehicleSpending { get; set; }
    }
}
