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


        public List<Patient> Pc {
            get { return _pc; }
        }

        
        public PatientCatalog()
        {
           _pc = new List<Patient>();
            _relativeCatalog = new RelativeCatalog();
            _hospitalCardCatalog = new HospitalCardCatalog();
        }
       

        public Patient CreatePatient(int ssn, string pName, string pAdress, int pAge, string rName, string rTlf, string relationship, int cID, int validTo)
        {
            HospitalCard pHospitalCard = _hospitalCardCatalog.CreateCard(cID, validTo); //New hospital card gets created by calling CreateCard,
                                                                                        //which also runs all the other code in that method.

            Relative pRelative = null;                                                  //New relative variable pointing at nothing gets created.
            if(pAge < 18) {                                                             //IF patient is under 18 (business logic),
                pRelative = _relativeCatalog.CreateRelativ(rName, rTlf, relationship);  //the var is relevant and gets assigned information through
            }                                                                           //the CreateRelativ method in the _relativeCatalog
            _patient = new Patient(ssn, pName, pAdress, pAge, pRelative, pHospitalCard);//New patient gets created using parameters and new instances
           _pc.Add(_patient); //Patient gets added to catalog

            return _patient;
        }
    }
}
