using System.ComponentModel.DataAnnotations;

namespace VasuthalozatPublicApplication.Entities
{
    public class User : AbstractEntity
    {
        static int IdGenerator = 0;

        private string _name;
        [Required]
        [MaxLength(64)]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _password;
        [Required]
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public User(string name, string password)
        {
            ID = ++IdGenerator;
            Name = name;
            Password = password;
        }
        public User()
        {

        }
    }
}
