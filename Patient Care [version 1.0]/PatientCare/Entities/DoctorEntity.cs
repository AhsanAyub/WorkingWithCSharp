using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class DoctorEntity
    {
        //this contains all the required information of each doctor
        public string doctorUserName { set; get; }
        public string doctorPassword { set; get; }
        public string doctorName { set; get; }
        public string doctorSpeciality { set; get; }
    }
}