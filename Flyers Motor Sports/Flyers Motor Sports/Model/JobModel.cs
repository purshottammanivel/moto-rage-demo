using System;
using System.Collections.Generic;
using System.Text;

namespace Flyers_Motor_Sports.Model
{
    public class JobModel
    {
        public string Car_Number { get; set; }
        public DateTime Date_Posted { get; set; }
        public bool IsCompleted { get; set; }
        public List<Modification> ServicesAvailable { get; set; }
    }
}
