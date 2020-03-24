using System;
using System.Collections.Generic;
using System.Text;

namespace Makuni1.Models
{
    public class Tuote
    {
        public string Ean { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int UserId { get; set; }
        public bool isOrganic { get; set; }
        public bool isLowCalory { get; set; }

        public bool Added_Sugar { get; set; }

        public string Other_Info { get; set; }
        public int Gross_Weight { get; set; }
        public int Net_Weight { get; set; }

    }
}
