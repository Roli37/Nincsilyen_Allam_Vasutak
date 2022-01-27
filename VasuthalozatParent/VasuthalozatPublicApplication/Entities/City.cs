using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasuthalozatPublicApplication.Entities
{
    public class City
    {
        static int IdGenerator = 0;
        public int ID { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        public City(string name)
        {
            ID = ++IdGenerator;
            Name = name;
        }
        public City()
        {

        }
    }
}
