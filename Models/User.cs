using System;
using System.Collections.Generic;

namespace serviceCar.Models.DbModels
{
    public partial class User
    {
        public int IdUser { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public virtual Conductor Conductor { get; set; }
    }
}
