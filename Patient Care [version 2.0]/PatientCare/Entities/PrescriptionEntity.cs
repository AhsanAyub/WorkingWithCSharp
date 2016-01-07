using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class PrescriptionEntity
    {
        public string prescriptionID { set; get; }
        public string prescriptionDate { set; get; }
        public string DoctorToPrescribe { set; get; }
        public int PrescribedPatient { set; get; }
        
        public string medicineName { set; get; }
        public string intakePeriod { set; get; }
        public int NumberOfDays { set; get; }
        public string CommentOnPrescrition { set; get; }
        
        public string testName { set; get; }
        public string CommmentOnTest { set; get; }
    }
}
