using System;
using System.Collections.Generic;
using System.Text;

namespace EstoquIN.Model
{
    class DadosProdInsumos
    {
        public int Id { get; set; }
        public int DadosInsumosId { get; set; }
        public DadosInsumos insumos { get; set; }
        public int DadosProdutosId { get; set; }
        public DadosProdutos produtos { get; set; }
    }
}
