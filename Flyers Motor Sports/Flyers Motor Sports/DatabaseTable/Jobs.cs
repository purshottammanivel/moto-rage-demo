using System;
using System.Collections.Generic;
using System.Text;

namespace Flyers_Motor_Sports.DatabaseTable
{
    public class Jobs
    {
        public string CarNumber { get; set; }
        public string SubmittedBy { get; set; }

        #region
        // Jobs as checklist
        public bool Denting { get; set; }
        public bool Moulding { get; set; }
        public bool Fabrication { get; set; }
        public bool Painting { get; set; }
        public bool Detailing { get; set; }
        public bool Cleaning { get; set; }
        #endregion
    }
}
