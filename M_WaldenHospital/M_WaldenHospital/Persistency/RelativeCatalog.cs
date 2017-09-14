using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M_WaldenHospital.Model;

namespace M_WaldenHospital.Persistency {
    public class RelativeCatalog {
        private List<Relative> _rc;
        private Relative _relative;


        public RelativeCatalog() {
            _rc = new List<Relative>();
        }


        public Relative CreateRelativ(string rName, string rTlf, string relationship) { //Responsible for creating and returning Relatives
            _relative = new Relative(rName, rTlf, relationship); //Creates relative with information given
            _rc.Add(_relative); //Adds to catalog
            return _relative; //Returns for the PatientCatalog
        }
    }
}
