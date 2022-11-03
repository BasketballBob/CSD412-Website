using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MVCWebApp.Models
{
    public class LocationModel
    {
        public long Id { get; set; }
        private string _key;

        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Country.ToLower() + Address.ToLower() + AreaCode, "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }

        public string Country { get; set; }
        public string Address { get; set; }
        public int AreaCode { get; set; }
    }
}
