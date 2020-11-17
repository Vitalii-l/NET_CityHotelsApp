using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Luchinskii Vitalii - JKTVR19


namespace CityHotelsApp
{
    class Program
    {
        class Hotel
        {
            public string Name { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
            public List<string> Services { get; set; }
            public Hotel()
            {
                Services = new List<string>();
            }
        }
        static void Main(string[] args)
        {
            List<Hotel> hotels = new List<Hotel>
            {
                new Hotel { Name = "Holiday Park Inn", City = "Tallinn", Address = "Roseni 5, 10111 Tallinn", Services = new List<string> { "Free WiFi","Pets allowed","Free parking"} },
                new Hotel { Name = "Metropol", City = "Tallinn", Address = "Roseni 13, 10111", Services = new List<string> { "Breakfast","Transfer","Swimming pool"} },
                new Hotel { Name = "Centennial", City = "Tallinn", Address = "Endla 15, 10122", Services = new List<string> { "Free WiFi", "Transfer","Swimming pool", "Free parking" } },
                new Hotel { Name = "Tartu", City = "Tartu", Address = "Soola 3, 51004", Services = new List<string> { "Free WiFi", "SPA","Conditioner", "Free parking" } },
                new Hotel { Name = "Sophia", City = "Tartu", Address = "Ringtee 75, 50407", Services = new List<string> { "Free WiFi", "Breakfast","Conditioner", "Free parking" } },
                new Hotel { Name = "ESTONIA Resort Hotel & Spa", City = "Pärnu", Address = "A. H. Tammsaare puiestee 6", Services = new List<string> { "Free WiFi", "SPA","Swimming pool", "Access to the beach", "Free parking" } },
                new Hotel { Name = "Strand SPA & Conference Hotel", City = "Pärnu", Address = "A. H. Tammsaare puiestee 35", Services = new List<string> { "Free WiFi", "SPA","Swimming pool", "Fitness", "Free parking" } },
                new Hotel { Name = "Toila Pikk Apartment", City = "Toila ", Address = "Pikk 87", Services = new List<string> { "Free WiFi", "Free parking" } }
            };

            // Список всех отелей
            var allHotels = from hotel in hotels select hotel;
            Console.WriteLine("\n\nHotels list");
            Console.WriteLine("\nCity \t \tName \t\t \tAddress \t \tServices");
            int i = 1;
            foreach (Hotel hotel in allHotels)
            {
                Console.Write($"{i}. {hotel.City} \t{hotel.Name} \t{hotel.Address}\t");
                
                foreach (var service in hotel.Services)
                {
                    Console.Write($"{service}, ");
                    //if (i == 1)
                    //{
                        
                    //} else {
                    //    Console.Write($"\t\t\t\t\t\t{service},\n");
                    //}
                    
                }
                Console.WriteLine("");
                i++;
            }

            // Список отелей в Таллине
            var city = "Tallinn";
            var selectedHotels = from hotel in hotels
                                 where hotel.City == city
                                 orderby hotel.Name
                                 select hotel;
            Console.WriteLine("\n\nHotels list in " + city);
            Console.WriteLine("\nCity \t \tName \t\t \tAddress \t \tServices");
            i = 1;
            foreach (Hotel hotel in selectedHotels)
            {
                Console.Write($"{i}. {hotel.City} \t{hotel.Name} \t{hotel.Address}\t");
                foreach (var service in hotel.Services)
                {
                    Console.Write($"{service}, ");
                }
                Console.WriteLine("");
                i++;
            }


            Console.Write("\n\nPress any key...");
            Console.ReadKey();

        }
    }
}
