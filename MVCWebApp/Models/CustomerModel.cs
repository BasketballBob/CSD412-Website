using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MVCWebApp.Models
{
    public class CustomerModel
    {
        public long Id { get; set;  }
        private string _key;

        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(FirstName.ToLower() + LastName.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
