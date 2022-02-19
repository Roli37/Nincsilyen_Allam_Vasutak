using System.Collections.Generic;
using VasuthalozatPublicApplication.Entities;

namespace VasuthalozatPublicApplication.Algorithms
{
    public class BFS
    {
        public static List<List<City>> BFSalgorithm(List<City> cities, List<Railway> railways, City from, City to)
        {
            Dictionary<City, List<City>> neighbors = new Dictionary<City, List<City>>();
            foreach (var c in cities)
            {
                neighbors[c] = new List<City>();
            }
            foreach (var r in railways)
            {
                neighbors[r.From].Add(r.To);
            }
            List<List<City>> BFS = Search(neighbors, from, to);
            return BFS;
        }
        private static List<List<City>> Search(Dictionary<City, List<City>> neighbors, City fromCity, City toCity)
        {
            List<List<City>> result = new List<List<City>>();
            Queue<List<City>> queue = new Queue<List<City>>();
            List<City> path = new List<City>();
            path.Add(fromCity);
            queue.Enqueue(path);
            while (queue.Count != 0)
            {
                path = queue.Dequeue();
                City lastCity = path[path.Count - 1];

                if (lastCity == toCity)
                {
                    result.Add(path);
                }
                List<City> last = neighbors[lastCity];
                for (int i = 0; i < last.Count; i++)
                {
                    if (isNotVisited(last[i], path))
                    {
                        List<City> newpath = new List<City>(path);
                        newpath.Add(last[i]);
                        queue.Enqueue(newpath);
                    }
                }
            }
            return result;
        }
        static bool isNotVisited(City x, List<City> path)
        {
            int size = path.Count;
            for (int i = 0; i < size; i++)
            {
                if (path[i] == x)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
