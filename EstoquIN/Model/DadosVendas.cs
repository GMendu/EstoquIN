using System;
using System.Collections.Generic;
using System.Text;

namespace EstoquIN.Model
{
    class DadosVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string FormPag { get; set; }
        public int Quant { get; set; }
        public double ValorTotal { get; set; }
        public double ValorUnit { get; set; }
        public bool Status { get; set; }
        public string NotaFiscal { get; set; }


        public int DadosProdutosId { get; set; }
        public DadosProdutos produto { get; set; }
        public int DadosClienteId { get; set; }
        public DadosCliente cliente { get; set; }

    }
}
