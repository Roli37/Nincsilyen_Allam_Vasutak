using System.Collections.Generic;
using System.Linq;
using VasuthalozatPublicApplication.Algorithms;
using VasuthalozatPublicApplication.Entities;
using VasuthalozatPublicApplication.Views;

namespace VasuthalozatPublicApplication.Models
{
    public class UserInterfaceViewModel
    {
        public static void LogOut(UserInterface userInterface)
        {
            LogIn logIn = new LogIn();
            userInterface.Close();
            logIn.Show();
        }
        public static List<List<City>> Kereses(List<City> cities, List<Railway> railways, string from, string to)
        {
            City fromCity = cities.First(x => x.Name == from);
            City toCity = cities.First(x => x.Name == to);
            List<List<City>> bfs = BFS.BFSalgorithm(cities, railways, fromCity, toCity);
            return bfs;
        }
    }
}
