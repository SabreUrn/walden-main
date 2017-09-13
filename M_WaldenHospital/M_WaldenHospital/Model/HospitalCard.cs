using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Chat;

namespace M_WaldenHospital.Model
{
  public  class HospitalCard
    {
        public int CId { get; set; }
        public int ValidTO { get; set; }


        public HospitalCard(int cId, int validTo)
        {
            CId = cId;
            ValidTO = validTo;  
        }
    }
}
