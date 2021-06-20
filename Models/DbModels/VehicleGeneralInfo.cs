using System;
using System.Collections.Generic;

namespace serviceCar.Models.DbModels
{
    public partial class VehicleGeneralInfo
    {
        public int IdVehicleGi { get; set; }
        public string MatriculNumber { get; set; }
        public string Code { get; set; }
        public string GreyCard { get; set; }
        public string ChassisNumber { get; set; }
        public string VehicleType { get; set; }
        public string Acquisition { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public int InUseYr { get; set; }
        public int Km { get; set; }
        public string BodyType { get; set; }
        public string FuelType { get; set; }

        public virtual Vehicle IdVehicleGiNavigation { get; set; }
    }
}
