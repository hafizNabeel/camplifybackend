using System;
using System.Collections.Generic;
using System.Text;

namespace Camplify.Data.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string UserID { get; set; }
        public string MechanicId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string VIN { get; set; }
        public string Chassis { get; set; }
        public string Registration { get; set; }
        public int IncidentId { get; set; }
    }
}
