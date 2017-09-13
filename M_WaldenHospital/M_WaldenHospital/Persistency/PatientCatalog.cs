using M_WaldenHospital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_WaldenHospital.Persistency
{
     public class PatientCatalog
     {

         private List<Patient> _pc;
        private RelativeCatalog _relativeCatalog;
        private HospitalCardCatalog _hospitalCardCatalog;
        private Patient _patient;







        // need for constructor to construct objects
        public PatientCatalog()
        {
           _pc = new List<Patient>();
            _relativeCatalog = new RelativeCatalog();
            _hospitalCardCatalog = new HospitalCardCatalog();



        }

       

        public void CreatePatient(int ssn, string pName, string pAdress, int pAge)
        {
           _patient = new Patient(ssn, pName, pAdress, pAge );
           _pc.Add(_patient);
        }

      
    }
}
