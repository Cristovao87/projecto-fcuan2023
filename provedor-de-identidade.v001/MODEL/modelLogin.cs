using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provedor_de_identidade.v001.MODEL
{
    public class modelLogin
    {
        public int IdLogin { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
