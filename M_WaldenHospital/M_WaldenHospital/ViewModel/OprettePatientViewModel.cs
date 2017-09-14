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



        public OprettePatientViewModel() {
            _ips = new InsurancePlanSystem();
            _patientCatalog = new PatientCatalog();
            _checkInsurancePatientCommand = new RelayCommand(CheckInsurance);
            _addPatientCommand = new RelayCommand(CreatePatient);
            _patientViewModelCollection = new ObservableCollection<PatientClass>();

        }



        private void CheckInsurance() {
            InsurancePlan myIP = _ips.getMember(SSN);
            Provider = myIP.Provider;
            ValidUntil = myIP.Validtil;
        }



        public void CreatePatient() {
            PatientClass newPatient = _patientCatalog.CreatePatient(SSN, PName, PAddress, PAge, RName, RTlf, Relationship, CID, ValidTo);
            PatientViewModelCollection.Add(newPatient);
        }




    }
}
