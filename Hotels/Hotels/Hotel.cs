using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    public class Hotel : IHotel
    {

        public List<HotelData> GetHotelData()
        {
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/" + "Hotels.Json";
            using (StreamReader r = new StreamReader(path))
            {
                var json = r.ReadToEnd();
                var hotels = JsonConvert.DeserializeObject<List<HotelData>>(json);

                return hotels;
            }

        }


        public HotelData GetHotelById(int id)
        {
            HotelData hotel = GetHotelData().Find(x => x.HotelId == id);
            return hotel;
        }
    }
}
