using System;
using System.Collections.Generic;
using System.Text;

namespace EstoquIN.Model
{
    class DadosUsuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int TipoUsuarioId { get; set; }
        public TiposUsuario Tipo { get; set; }
    }
}
