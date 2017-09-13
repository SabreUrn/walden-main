using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_WaldenHospital.Model
{
   public class Relative
    {
        public string RName { get; set; }
        public string RTlf { get; set; }
        public string Relationship { get; set;}


        public Relative(string rName, string rTlf, string relationship)
        {
            RName = rName;
            RTlf = rTlf;
            Relationship = relationship;    
        }
    }
}
