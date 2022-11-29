using System;
using System.Collections.Generic;
using System.Text;

namespace Flyers_Motor_Sports.DatabaseTable
{
    public class Database
    {
        static Database _instance;
        public static Database Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Database();
                }
                return _instance;
            }
        }
        public List<Job> Jobs { get; private set; }
        public List<Car> Cars { get; private set; }
        public List<Modification> Modifications { get; private set; }
        public List<EmployeeModel> Employees { get; private set; }

        private Database()
        {
            Jobs = new List<Job>();
            Cars = new List<Car>();
            Modifications = new List<Modification>();
            Employees = new List<EmployeeModel>();
        }
    }

    public class InmemoryRepository : IRepository
    {
        public void CreateJob(Job job)
        {
            Database.Instance.Jobs.Add(job);
        }

        public List<Job> GetAvailableJobs()
        {
            return Database.Instance.Jobs;
        }
    }

    public interface IRepository
    {
        void CreateJob(Job job);
        List<Job> GetAvailableJobs();
    }
}
