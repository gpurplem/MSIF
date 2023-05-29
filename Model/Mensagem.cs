using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIF.Model
{
    public class Mensagem
    {
        public int idRemetente { get; set; }
        public int idDestinatario { get; set; }
        public DateTime dataHoraEnvio { get; set; }
        public string texto { get; set; }
        public int status { get; set; }
    }
}

