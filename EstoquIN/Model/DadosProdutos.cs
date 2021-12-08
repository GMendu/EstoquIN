using System;
using System.Collections.Generic;
using System.Text;

namespace EstoquIN.Model
{
    class DadosProdutos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Peso { get; set; }
        public string ValorVarejo { get; set; }
        public string ValorAtacado { get; set; }
        public string CodBarras { get; set; }
        public string Obs { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
}
