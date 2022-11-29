using System;
using System.Collections.Generic;
using System.Text;

namespace Flyers_Motor_Sports.DatabaseTable
{
    public class Department
    {
        public string Name { get; set; }

        public List<EmployeeModel> Employees { get; set; }
    }

    public class EmployeeModel
    {
        public string Name { get; set; }
    }
}
