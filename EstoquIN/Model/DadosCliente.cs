using System;
using System.Collections.Generic;
using System.Text;

namespace EstoquIN.Model
{
    class DadosCliente
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string Razao { get; set; }
        public string Inscricao { get; set; }
        public string NomeFantasia { get; set; }
        public string Obs { get; set; }
        public string ContatoNome { get; set; }
        public string ContatoEmail { get; set; }
        public string ContatoTelefone { get; set; }
        public string endereco { get; set; }
        public double freq_compra { get; set; }
        public override string ToString()
        {
            return NomeFantasia;
        }
    }
}
