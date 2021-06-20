using System;
using System.Collections.Generic;

namespace serviceCar.Models.DbModels
{
    public partial class VehicleFuel
    {
        public int IdSpFu { get; set; }
        public decimal Quantity { get; set; }

        public virtual VehicleSpending IdSpFuNavigation { get; set; }
    }
}
