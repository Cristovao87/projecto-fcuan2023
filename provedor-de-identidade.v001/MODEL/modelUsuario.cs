using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provedor_de_identidade.v001.MODEL
{
    public class modelUsuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public int IdPerfil { get; set; }
        public bool EstadoUsuario { get; set; }
    }
}
