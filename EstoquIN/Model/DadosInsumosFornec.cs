using System;
using System.Collections.Generic;
using System.Text;

namespace EstoquIN.Model
{
    class DadosInsumosFornec
    {
        public int DadosFornecId { get; set; }
        public DadosFornec fornec { get; set; }
        public int DadosInsumosId { get; set; }
        public DadosInsumos insumos { get; set; }
    }
}
