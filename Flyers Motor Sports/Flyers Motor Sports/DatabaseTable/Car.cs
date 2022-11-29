using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flyers_Motor_Sports.DatabaseTable
{
    public class Car
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CarNumber { get; set; }
        public string CarModel { get; set; }
    }
}
