using System;
using System.Collections.Generic;
using System.Text;

namespace EstoquIN.Model
{
    class DadosCompras
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string FormPag { get; set; }
        public int Quant { get; set; }
        public double ValorTotal { get; set; }
        public double ValorUnit { get; set; }
        public bool Status { get; set; }
        public string NotaFiscal { get; set; }

        //estrangeiras
        public int DadosInsumosId { get; set; }
        public DadosInsumos insumos { get; set; }
        public int DadosFornecId { get; set; }
        public DadosFornec fornec { get; set; }

    }
}
