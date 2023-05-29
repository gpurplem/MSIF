using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIF.Model
{
    public class Solicitacao
    {
        public int ID { get; set; }
        public int idRemetente { get; set; }
        public int idDestinatario { get; set; }
    }
}
