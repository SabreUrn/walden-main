using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_WaldenHospital.Model
{
    public class Patient
    {
        public int SSN { get; set; }
        public string PName { get; set; }
        public string PAddress { get; set; }
        public int PAge { get; set; }
        public Relative PRelative { get; set; }
        public HospitalCard PHospitalCard { get; set; }


        public Patient(int ssn, string pName, string pAddress, int pAge, Relative pRelative, HospitalCard pHospitalCard)
        {
            SSN = ssn;
            PName = pName;
            PAddress = pAddress;
            PAge = pAge;
            PRelative = pRelative;
            PHospitalCard = pHospitalCard;
        }
    }
}
