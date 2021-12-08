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
        public string Quant { get; set; }
        public string ValorTotal { get; set; }
        public string ValorUnit { get; set; }
        public bool Status { get; set; }
        public string NotaFiscal { get; set; }


        public int DadosProdutosId { get; set; }
        public DadosProdutos produto { get; set; }
        public int DadosClienteId { get; set; }
        public DadosCliente cliente { get; set; }
        public int DadosImagesId { get; set; }
        public DadosImages Images { get; set; }

    }
}
