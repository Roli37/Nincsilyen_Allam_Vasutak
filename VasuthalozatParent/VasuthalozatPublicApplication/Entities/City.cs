using System.ComponentModel.DataAnnotations;

namespace VasuthalozatPublicApplication.Entities
{
    public class City : AbstractEntity
    {
        static int IdGenerator = 0;

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
