using System;
using System.Collections.Generic;
using System.Text;

namespace Makuni1.Models
{
    public class Allergeeni
    {
        public string Name { get; set; }
        public string Arvo { get; set; }

        public Allergeeni(string name, string arvo)
        {
            Name = name;
            Arvo = arvo;
        }

    }

    
}
