using Flyers_Motor_Sports.DatabaseTable;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Flyers_Motor_Sports.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<Department> DepartmentCollection { get; set; }

        public MainPageViewModel()
        {            
            DepartmentCollection = new ObservableCollection<Department>(GetDepartments());
        }

        private List<Department> GetDepartments()
        {
            Department dep_one = new Department
            {
                Name = "Denting",
                Employees = new List<Employee>
                {
                    new Employee{Name = "Selvam"},
                    new Employee{Name = "Sudhakar"},
                }
            };

            Department dep_two = new Department
            {
                Name = "Moulding",
                Employees = new List<Employee>
                {
                    new Employee{Name = "Venkat"},
                    new Employee{Name = "Anand"},
                    new Employee{Name = "Desapen"},
                }
            };

            Department dep_three = new Department
            {
                Name = "Fabrication",
                Employees = new List<Employee>
                {
                    new Employee{Name = "Kiafathy"},
                    new Employee{Name = "Libin"},
                }
            };


            return new List<Department>
            {
                dep_one, dep_two, dep_three
            };

        }
    }
}
