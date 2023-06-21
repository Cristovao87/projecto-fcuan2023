using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provedor_de_identidade.v001.MODEL
{
    public class modelUsuarioAplicacao
    {
        public int IdUsuario { get; set; }
        public int IdAplicacao { get; set; }
        public bool EstadoUsuarioApp { get; set; }
    }
}
