using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M_WaldenHospital.Model;

namespace M_WaldenHospital.Persistency
{
   public  class RelativeCatalog
   {


       private List<Relative> _rc;
       private Relative _relative;
    


        // need for constructor to construct objects
        public RelativeCatalog()
        {
            _rc = new List<Relative>();
            
           

        }


        public void CreateRelativ(string rName, string rTlf, string relationship)
        {
              // Usikker hvad som skal she her??

            _relative = new Relative(rName, rTlf, relationship);
            _rc.Add(_relative);

        }
    }
}
