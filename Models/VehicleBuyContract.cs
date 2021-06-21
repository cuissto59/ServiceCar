using System;
using System.Collections.Generic;

namespace serviceCar.Models.DbModels
{
    public partial class VehicleBuyContract
    {
        public int IdVehicleBc { get; set; }
        public string Provider { get; set; }
        public DateTime? BuyDate { get; set; }
        public string ContractNumber { get; set; }
        public int? WarrantyYears { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Tva { get; set; }

        public virtual Vehicle IdVehicleBcNavigation { get; set; }
    }
}
