using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.API
{
    class Bancos
    {
        public string ispb { get; set; }
        public string name { get; set; }
        public int? code { get; set; }
        public string fullName { get; set; }

        public string DisplayName
        {
            get { return $"{code} - {name}"; }
        }
    }
}
