﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIF.Model
{
    public class Solicitacao
    {
        public int SolicitacaoId { get; set; }
        public int Remetente { get; set; }
        public int Destinatario { get; set; }
        public int Status { get; set; }
    }
}
