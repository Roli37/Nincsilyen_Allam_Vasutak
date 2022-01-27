using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VasuthalozatPublicApplication.Entities
{
    public class ReadFiles
    {
        public static List<City> ReadCities()
        {
            List<City> cities = new List<City>();
            using (var sr = new StreamReader("cities.txt"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    City city = new City(sor);
                    cities.Add(city);
                }
            }
            return cities;
        }
        public static List<Railway> ReadRailways(IEnumerable<City> cities)
        {
            List<Railway> railways = new List<Railway>();
            using (var sr = new StreamReader("railways.txt"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    var seged = sor.Split(";");
                    int km = int.Parse(seged[2]);
                    Railway railway = new Railway(cities.First(x => x.Name == seged[0]).ID, cities.First(x => x.Name == seged[1]).ID, km);
                    railways.Add(railway);
                }
            }
            return railways;
        }
    }
}
