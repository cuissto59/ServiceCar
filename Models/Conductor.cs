using System;
using System.Collections.Generic;

namespace serviceCar.Models.DbModels
{
    public partial class Conductor
    {
        public Conductor()
        {
            Vehicle = new HashSet<Vehicle>();
            VehicleSpending = new HashSet<VehicleSpending>();
        }

        public int User { get; set; }
        public string Cin { get; set; }
        public int TelephoneNumber { get; set; }
        public string Adress { get; set; }
        public bool Active { get; set; }

        public virtual User UserNavigation { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
        public virtual ICollection<VehicleSpending> VehicleSpending { get; set; }
    }
}
