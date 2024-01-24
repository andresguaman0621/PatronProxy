using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy
{
    class ProxyMiServidor:Servidor
    {
        MiServidor miServidor;
        private int puerto;
        private String host;

        public ProxyMiServidor(int p, String h)
        {
            puerto = p; 
            host = h;
            miServidor = null;
        }

        
        public override string descargar(string url)
        {
            string resultado = String.Empty;
            if (restringidgo(url))
            {
                if(miServidor == null)
                    miServidor = new MiServidor(puerto,host);

                resultado = miServidor.descargar(url);
            }
            else
            {
                resultado = "No es posible descargar desde esta ubicacion";
            }
            
                
            

        return resultado;
        }

        public Boolean restringidgo(string ruta)
        {
            Boolean descargaPermitida = false;
            if (ruta == "descargaPermitida")
                descargaPermitida = true;
            return descargaPermitida;
        }   
    }
}
