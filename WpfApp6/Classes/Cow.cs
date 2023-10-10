using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    internal class Cow
    {
        public string Name { get; set; }
        public string Voice { get; set; }
        public string Image { get; set; }
        public string Age { get; set; }

        public string FullAgeString
        {
            get
            {
                return $"{DateTime.Now.ToShortTimeString()} {Name} {Age} лет";
            }
        
        }


    }
}
