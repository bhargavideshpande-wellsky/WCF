using Client.HotelService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            HotelClient hc = new HotelClient("BasicHttpBinding_IHotel");
            do
            {
                Console.WriteLine("\n1. Get all Hotels \n2. Get Specific Hotel\n3. Exit\nEnter your choice:");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        var hotel = hc.GetHotelData();
                        foreach (var item in hotel)
                        {
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("Hotel Id:" + item.HotelId);
                            Console.WriteLine("Hotel Name:" + item.HotelName);
                            Console.WriteLine("Hotel Address:" + item.HotelAddress);
                            Console.WriteLine("Hotel Rating:" + item.HotelRatings);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Hotel Id:");
                        int id = int.Parse(Console.ReadLine());
                        var hotelById = hc.GetHotelById(id);

                        if (hotelById == null)
                        {
                            Console.WriteLine("No such hotel is present!");
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("Hotel Id:" + hotelById.HotelId);
                            Console.WriteLine("Hotel Name:" + hotelById.HotelName);
                            Console.WriteLine("Hotel Address:" + hotelById.HotelAddress);
                            Console.WriteLine("Hotel Rating:" + hotelById.HotelRatings);
                        }
                        break;

                    case 3:
                        i = 0;
                        break;
                }

            } while (i == -1);
        }
    }
}
