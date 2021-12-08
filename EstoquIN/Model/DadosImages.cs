using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoquIN.Model
{
    class DadosImages
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public override string ToString()
        {
            return Path;
        }
    }
}
