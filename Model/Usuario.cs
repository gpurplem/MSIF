using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIF.Model
{
    public class Usuario
    {
        public int ID { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string nomeCompleto { get; set; }
        public string apelido { get; set; }
        public int status { get; set; }
    }
}
