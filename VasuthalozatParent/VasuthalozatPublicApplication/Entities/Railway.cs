using System.ComponentModel.DataAnnotations;

namespace VasuthalozatPublicApplication.Entities
{
    public class Railway : AbstractEntity
    {
        static int IdGenerator = 0;

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
