using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.API
{
    public class Bancos
    {
        public string ispb;
        public string name;
        public int? code;
        public string fullName;

        public string DisplayName
        {
            get { return $"{code} - {name}"; }
        }
    }
}
