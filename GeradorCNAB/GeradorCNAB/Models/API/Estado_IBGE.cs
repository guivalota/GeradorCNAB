using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.API
{
    public class Estado_IBGE
    {
        public int id { get; set; }
        public string sigla { get; set; }
        public string nome { get; set; }
        public Regiao regiao { get; set; }

        public string DisplayName
        {
            get { return $"{sigla} - {nome}"; }
        }
    }
    public class Regiao
    {
        public int id { get; set; }
        public string sigla { get; set; }
        public string nome { get; set; }
    }
}
