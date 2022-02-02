using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasuthalozatAdminApplication.Entities
{
    public class Railway
    {
        static int IdGenerator = 0;
        public int ID { get; set; }

        public int FromID { get; set; }
        public int ToID { get; set; }
        [Required]
        public virtual City From { get; set; }

        [Required]
        public virtual City To { get; set; }

        [Required]
        public int Km { get; set; }

        public Railway(int from, int to, int km)
        {
            ID = ++IdGenerator;
            FromID = from;
            ToID = to;
            Km = km;
        }
        public Railway()
        {

        }
    }
}
