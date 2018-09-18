using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    [ServiceContract]
    public interface IHotel
    {
        [OperationContract]
        List<HotelData> GetHotelData();
        [OperationContract]
        HotelData GetHotelById(int id);
    }
}
