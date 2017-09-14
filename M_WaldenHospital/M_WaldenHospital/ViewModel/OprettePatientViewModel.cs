using M_WaldenHospital.Command;
using M_WaldenHospital.InsurancePlanService;
using M_WaldenHospital.Persistency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_WaldenHospital.ViewModel
{
   public  class OprettePatientViewModel : ViewModelBase
   {

       private InsurancePlanSystem _ips;
       private PatientCatalog _patientCatalog;
       private int _ssn;
       private string _provider;
       private string _validUntil;
       private RelayCommand _checkInsurancePatientCommand;

       public RelayCommand CheckInsurancePatientCommand
        {
           get { return _checkInsurancePatientCommand; }
           set { _checkInsurancePatientCommand = value; }   
       }
       

       public int SSN
       {
           get { return _ssn; }
           set
           {
               _ssn = value; 
                OnPropertyChanged("CPR");
               
           }
       }

       public string Provider
       {
           get { return _provider; }
           set
           {
               _provider = value;
               OnPropertyChanged("Provider");
            }
       }


       public string ValidUntil
       {
           get { return _validUntil; }
           set
           {
               _validUntil = value; 
               OnPropertyChanged("ValidUntil");
           }
       }

        public OprettePatientViewModel()
       {
           _ips = new InsurancePlanSystem();
           _patientCatalog = new PatientCatalog();
           _checkInsurancePatientCommand = new RelayCommand(CheckInsurance);

            
       }


       private void CheckInsurance()
       {
           InsurancePlan  myIP = _ips.getMember(SSN);
           Provider = myIP.Provider;
           ValidUntil = myIP.Validtil;
          

       }



       public void CreatePatient(int ssn, string pName, string pAdress, int pAge, string rName, string rTlf, string relationship, int cID, int validTo)
       {
           _patientCatalog.CreatePatient(ssn, pName, pAdress, pAge, rName, rTlf, relationship , cID, validTo);
        }


        
        
    }
}
