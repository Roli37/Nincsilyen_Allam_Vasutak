using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VasuthalozatAdminApplication.Database;
using VasuthalozatAdminApplication.Entities;

namespace VasuthalozatAdminApplication.Algorithms
{
    public class Prim
    {
        private readonly VasutContext _vasutContext;
        public Prim(VasutContext vasutContext)
        {
            _vasutContext = vasutContext;
        }
        public void PrimAlg()
        {
            List<City> cities = _vasutContext.Cities.ToList();
            List<Railway> railways = _vasutContext.Railways.ToList();

            //...

        }
        
    }
}
