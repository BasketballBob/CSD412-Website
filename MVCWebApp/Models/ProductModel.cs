using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MVCWebApp.Models
{
    public class ProductModel
    {
        public long Id { get; set; }
        private string _key;

        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Name.ToLower() + Brand.ToLower() + Price, "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }

        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
    }
}
