using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using M_WaldenHospital.Model;

namespace M_WaldenHospital.Persistency
{
    public class HospitalCardCatalog
    {

        // need for constructor to construct objects

        private List<HospitalCard> _hc;
        private HospitalCard _hospitalCard;
        
     

        public HospitalCardCatalog()
        {
            _hc = new List<HospitalCard>();
          


        }

        public HospitalCard CreateCard(int cID , int validTo)
        {
            _hospitalCard = new HospitalCard(cID, validTo);
            _hc.Add(_hospitalCard);
            //TODO: Return _hospitalCard
            return _hospitalCard;
        }


    }
}
