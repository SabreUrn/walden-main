using M_WaldenHospital.Command;
using M_WaldenHospital.InsurancePlanService;
using M_WaldenHospital.Persistency;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientClass = M_WaldenHospital.Model.Patient;

namespace M_WaldenHospital.ViewModel {
    public class OprettePatientViewModel : ViewModelBase {

        #region Instance fields
        private InsurancePlanSystem _ips;
        private PatientCatalog _patientCatalog;
        private int _ssn;
        private string _provider;
        private string _validUntil;
        private string _pName;
        private string _pAddress;
        private int _pAge;
        private int _cId;
        private int _validTo;
        private string _rName;
        private string _rTlf;
        private string _relationship;
        private ObservableCollection<PatientClass> _patientViewModelCollection;

        private RelayCommand _checkInsurancePatientCommand;
        private RelayCommand _addPatientCommand;
        #endregion


        #region Properties
        public RelayCommand CheckInsurancePatientCommand {
            get { return _checkInsurancePatientCommand; }
            set { _checkInsurancePatientCommand = value; }
        }

        public RelayCommand AddPatientCommand {
            get { return _addPatientCommand; }
            set { _addPatientCommand = value; }
        }

        public int SSN {
            get { return _ssn; }
            set {
                _ssn = value;
                OnPropertyChanged("CPR");

            }
        }

        public string Provider {
            get { return _provider; }
            set {
                _provider = value;
                OnPropertyChanged("Provider");
            }
        }


        public string ValidUntil {
            get { return _validUntil; }
            set {
                _validUntil = value;
                OnPropertyChanged("ValidUntil");
            }
        }

        public string PName {
            get { return _pName; }
            set {
                _pName = value;
                OnPropertyChanged("PName");
            }
        }
        
        public string PAddress {
            get { return _pAddress; }
            set {
                _pAddress = value;
                OnPropertyChanged("PAddress");
            }
        }

        public int PAge {
            get { return _pAge; }
            set {
                _pAge = value;
                OnPropertyChanged("PAge");
            }
        }

        public int CID {
            get { return _cId; }
            set {
                _cId = value;
                OnPropertyChanged("CID");
            }
        }
        
        public int ValidTo {
            get { return _validTo; }
            set {
                _validTo = value;
                OnPropertyChanged("ValidTo");
            }
        }

        public string RName {
            get { return _rName; }
            set {
                _rName = value;
                OnPropertyChanged("RName");
            }
        }

        public string RTlf {
            get { return _rTlf; }
            set {
                _rTlf = value;
                OnPropertyChanged("RTlf");
            }
        }

        public string Relationship {
            get { return _relationship; }
            set {
                _relationship = value;
                OnPropertyChanged("Relationship");
            }
        }

        public ObservableCollection<PatientClass> PatientViewModelCollection {
            get { return _patientViewModelCollection; }
            set {
                _patientViewModelCollection = value;
                OnPropertyChanged("PatientViewModelCollection");
            }
        }
        #endregion


        #region Constructor
        public OprettePatientViewModel() {
            _ips = new InsurancePlanSystem();
            _patientCatalog = new PatientCatalog();
            _checkInsurancePatientCommand = new RelayCommand(CheckInsurance);
            _addPatientCommand = new RelayCommand(CreatePatient);
            _patientViewModelCollection = new ObservableCollection<PatientClass>();

        }
        #endregion


        #region Methods
        private void CheckInsurance() { //Responsible for validating insurance
            InsurancePlan myIP = _ips.getMember(SSN);   //Sends SSN to the insurer and assigns the insurance it returns to myIP
            Provider = myIP.Provider;                   //Updates the Provider field for the view layer
            ValidUntil = myIP.Validtil;                 //Updates the ValidUntil field for the view layer
        }
        
        public void CreatePatient() { //Responsible for patient creation
            PatientClass newPatient = _patientCatalog.CreatePatient                     //Sends data to the PatientCatalog in the model
                (SSN, PName, PAddress, PAge, RName, RTlf, Relationship, CID, ValidTo);  //layer and assigns the Patient it returns
            PatientViewModelCollection.Add(newPatient); //Adds the patient to ObservableCollection so it's useable in the view layer
        }
        #endregion
    }
}
