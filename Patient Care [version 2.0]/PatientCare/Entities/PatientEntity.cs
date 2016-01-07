using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class PatientEntity
    {
        public int patiendID { set; get; }
        public string patientName { set; get; }
        public int patientAge { set; get; }
        public string patientGender { set; get;  }
        public string patientAddress { set; get; }
    }
}
