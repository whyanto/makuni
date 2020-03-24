using System;
using System.Collections.Generic;
using System.Text;

namespace Makuni1.Models
{
    public class Ravintoarvot
    {
        public string EAN { get; set; }
        public string Energia { get; set; }
        public double Rasva { get; set; }
        public double Tyydyttyneita { get; set; }
        public double Hiilihydraatit { get; set; }
        public double Sokereita { get; set; }
        public double Ravintokuitua { get; set; }
        public double Proteini { get; set; }
        public double Suola { get; set; }
    }
}
