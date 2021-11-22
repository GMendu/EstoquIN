using System;
using System.Collections.Generic;
using System.Text;

namespace EstoquIN.Model
{
    class DadosProdutos
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double ValorVarejo { get; set; }
        public double ValorAtacado { get; set; }
        public string CodBarras { get; set; }
    }
}
