using Services.Dtos.Reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Services.Messages.Reserva
{
    [DataContract]
    public class IncluirReservaRequest
    {
        [DataMember(Name = "Reserva")]
        public IncluirReservaDto Reserva { get; set; }
    }
}
