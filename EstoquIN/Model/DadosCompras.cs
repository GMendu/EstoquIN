using System;
using System.Collections.Generic;
using System.Text;

namespace EstoquIN.Model
{
    class DadosCompras
    {
        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public string FormPag { get; set; }
        public string Quant { get; set; }
        public string ValorTotal { get; set; }
        public string ValorUnit { get; set; }
        public bool Status { get; set; }
        public string NotaFiscal { get; set; }

        //estrangeiras
        public int DadosInsumosId { get; set; }
        public DadosInsumos Insumos { get; set; }
        public int DadosFornecId { get; set; }
        public DadosFornec Fornec { get; set; }
        public int DadosImagesId { get; set; }
        public DadosImages Images { get; set; }

    }
}
