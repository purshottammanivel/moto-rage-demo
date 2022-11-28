using System;
using System.Collections.Generic;
using System.Text;

namespace Flyers_Motor_Sports.DatabaseTable
{
    public class Department
    {
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public string Name { get; set; }
    }
}
