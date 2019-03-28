using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos.Reserva
{
    public class RetornoIncluirReservaDto
    {
        [DataMember(Name = "Codigo")]
        public Int32 Codigo { get; set; }
        [DataMember(Name = "Mensagem")]
        public string Mensagem { get; set; }
    }
}
