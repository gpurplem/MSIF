using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIF.Model
{
    public class Recado
    {
        public int RecadoId { get; set; }
        public int Remetente { get; set; }
        public int Destinatario { get; set; }
        public DateTime Dataenvio { get; set; }
        public string Texto { get; set; }
        public int Status { get; set; }
    }
}
