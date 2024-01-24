﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy
{
    class MiServidor:Servidor
    {
        private int puerto;
        private String host;
            
        public MiServidor(int p, String h)
        {
            puerto = p;
            host = h;
        }

        public override string descargar(String url)
        {
            return "Descargado de: " + host;
        }
    }
}
