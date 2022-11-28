using Flyers_Motor_Sports.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using static Flyers_Motor_Sports.Model.JobModel;

namespace Flyers_Motor_Sports.ViewModel
{
    public class JobViewModel
    {
        public ObservableCollection<JobModel> listofJobs { get; set; }
        public JobViewModel()
        {
            listofJobs = new ObservableCollection<JobModel>();
            getJobs();
        }

        private void getJobs()
        {
            //JobModel job_one = new JobModel
            //{
            //    Date_Posted = new DateTime(2022, 11, 01),
            //    Car_Number = "MH03CF6671",
            //    IsCompleted = false,
            //    Modifications = new List<Modification>
            //    {
            //        new Modification{ Denting = true },
            //        new Modification{ Detailing = true },
            //        new Modification{ Fabrication = true },
            //        new Modification{ Moulding = true },
            //        new Modification{ Painting = true }
            //    }
            //};

            //JobModel job_two = new JobModel
            //{
            //    Date_Posted = new DateTime(2022, 11, 01),
            //    Car_Number = "MH03CF6671",
            //    IsCompleted = false,
            //    Modifications = new List<Modification>
            //    {
            //        new Modification{ Denting = true },
            //        new Modification{ Detailing = true },
            //        new Modification{ Fabrication = false },
            //        new Modification{ Moulding = false },
            //        new Modification{ Painting = true }
            //    }
            //};

            //JobModel job_three = new JobModel
            //{
            //    Date_Posted = new DateTime(2022, 11, 01),
            //    Car_Number = "MH03CF6671",
            //    IsCompleted = false,
            //    Modifications = new List<Modification>
            //    {
            //        new Modification{ Denting = false },
            //        new Modification{ Detailing = false },
            //        new Modification{ Fabrication = true },
            //        new Modification{ Moulding = true },
            //        new Modification{ Painting = false }
            //    }
            //};

            //return new List<Modification>
            //{
            //    job_one, job_two, job_three
            //};

            //JobModel job_two = new JobModel()
            //{ Date_Posted = new DateTime(2022, 11, 02), Car_Number = "MH02CF5555", IsCompleted = true };
            //listofJobs.Add(job_two);

            //JobModel job_three = new JobModel()
            //{ Date_Posted = new DateTime(2022, 11, 03), Car_Number = "MH01CF9876", Modification = "Fabrication", IsCompleted = false };
            //listofJobs.Add(job_three);

            //JobModel job_four = new JobModel()
            //{ Date_Posted = new DateTime(2022, 11, 04), Car_Number = "MH12DD2435", Modification = "Detailing", IsCompleted = true };
            //listofJobs.Add(job_four);

            //JobModel job_five = new JobModel()
            //{ Date_Posted = new DateTime(2022, 11, 05), Car_Number = "MH11YN1243", Modification = "Denting", IsCompleted = false };
            //listofJobs.Add(job_five);
        }
    }
}
