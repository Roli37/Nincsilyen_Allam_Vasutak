using System.Collections.Generic;
using System.Linq;
using VasuthalozatAdminApplication.Entities;

namespace VasuthalozatAdminApplication.Algorithms
{
    public class Kruskal
    {
        public static List<Railway> KruskalAlgSecondTry(List<City> cities, List<Railway> railways)
        {
            //Double list city
            //List MST
            //While (listaban valamelyik lista count == cities count)
            //  minRailway.km = int.max
            //  foreach (railways as r)
            //      if (nincs benne az mst-ben)
            //          if (r.km < minRailway.km)
            //              if (külön halmazban (listában) vannak)
            //                  minRailway = r
            //  List where contains mR.from: addrange (list where contains mR.to)
            //  List where contains to -> clear
            //  MST.add(mR)
            //endwhile

            List<List<City>> list = new List<List<City>>();
            for (int i = 0; i < cities.Count; i++)
            {
                List<City> city = new List<City>
                {
                    cities[i]
                };
                list.Add(city);
            }
            List<Railway> minimumSpanningTree = new List<Railway>();

            while (true)
            {
                if (list.Any(x => x.Count == cities.Count))
                {
                    break;
                }
                Railway minWeightRailway = new Railway(-1, -1, int.MaxValue);
                foreach (Railway r in railways)
                {
                    if (!minimumSpanningTree.Contains(r))
                    {
                        if (r.Km < minWeightRailway.Km)
                        {
                            if (!list.FirstOrDefault(x => x.Contains(r.From)).Contains(r.To))
                            {
                                minWeightRailway = r;
                            }
                        }
                    }
                }
                List<City> localList = new List<City>();
                foreach (City localListCity in list.First(x => x.Contains(minWeightRailway.From)))
                {
                    localList.Add(localListCity);
                }
                list.Remove(list.First(x => x.Contains(minWeightRailway.From)));
                list.Where(x => x.Contains(minWeightRailway.To)).First().AddRange(localList);
                minimumSpanningTree.Add(minWeightRailway);
            }
            return minimumSpanningTree;
            
        }
        public static void KruskalAlgFirstTry(List<City> cities, List<Railway> railways)
        {
            //List MST
            //Havetovisit = all cities;
            //While(havetovisit!=empty)
            //  minRailway.km = int.max
            //  foreach (railways as r)
            //      if (havetovisit.contains(r.from vagy r.to))
            //          if (r.km < minRailway.km)
            //              minRailway = r
            //  Havetovisit.remove(if contains) (minRailway.from, minRailway.to)
            //  MST.add(minRailway)
            //endwhile

            List<MSTelement> minimumSpanningTree = new List<MSTelement>();
            List<City> haveToVisit = cities;
            while (haveToVisit.Count > 0)
            {
                MSTelement minWeightRailway = new MSTelement() { From = null, To = null, Weight = int.MaxValue };
                foreach (Railway r in railways)
                {
                    if (haveToVisit.Contains(r.From) || haveToVisit.Contains(r.To))
                    {
                        if (r.Km < minWeightRailway.Weight)
                        {
                            minWeightRailway.From = r.From;
                            minWeightRailway.To = r.To;
                            minWeightRailway.Weight = r.Km;
                        }
                    }
                }
                minimumSpanningTree.Add(minWeightRailway);
                if (haveToVisit.Contains(minWeightRailway.From))
                {
                    haveToVisit.Remove(minWeightRailway.From);
                }
                if (haveToVisit.Contains(minWeightRailway.To))
                {
                    haveToVisit.Remove(minWeightRailway.To);
                }
            }
        }
        public class MSTelement
        {
            public City From;
            public City To;
            public int Weight;
            public MSTelement(City from, City to, int weight)
            {
                From = from;
                To = to;
                Weight = weight;
            }
            public MSTelement()
            {

            }
        }
        
    }
}
