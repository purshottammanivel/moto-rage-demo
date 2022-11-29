using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Flyers_Motor_Sports.DatabaseTable
{
    public class Modification
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string ServiceOffered { get; set; }
    }
}
