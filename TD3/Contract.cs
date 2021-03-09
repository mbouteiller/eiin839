using System;
using System.Collections.Generic;
using System.Text;

namespace TD3
{
    class Contract
    {
        public string name { get; set; }
        public string commercial_name { get; set; }
        public string country_code { get; set; }

        public override string ToString()
        {
            return "[" + name + " : " + commercial_name + "  " + country_code + "]";
        }

    }
}
