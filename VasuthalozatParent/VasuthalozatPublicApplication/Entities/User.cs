using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasuthalozatPublicApplication.Entities
{
    public class User
    {
        static int IdGenerator = 0;
        public int ID { get; set; }

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
