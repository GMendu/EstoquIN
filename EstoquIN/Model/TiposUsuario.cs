﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoquIN.Model
{
    class TiposUsuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
}
