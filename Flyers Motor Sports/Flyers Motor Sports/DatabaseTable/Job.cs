using SQLite;
using System;
using System.Collections.Generic;

namespace Flyers_Motor_Sports.DatabaseTable
{
    public class Job
    {
        //public static List<Modification> ServicesAvailable => new List<Modification>
        //{
        //    new Modification{ Name = "Denting"},
        //    new Modification{ Name = "Moulding"},
        //    new Modification{ Name = "Fabrication"},
        //    new Modification{ Name = "Painting"},
        //    new Modification{ Name = "Deatailing"},
        //    new Modification{ Name = "Cleaning"},
        //};
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public IEnumerable<Modification> ServicesOffered { get; set; }

        public IEnumerable<EmployeeModel> AssignedEmployee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleModel { get; set; }
        public string SubmittedBy { get; set; }
        public bool IsCompleted { get; set; } = false;
    }
}
