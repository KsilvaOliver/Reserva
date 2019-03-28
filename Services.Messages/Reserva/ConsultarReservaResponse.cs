using Services.Dtos.Reserva;
using Services.Messages.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Services.Messages.Reserva
{
    public class ConsultarReservaResponse: BaseResponse
    {
        public ConsultarReservaResponse()
        {
            ErrorMessages = new List<string>();
        }

        [DataMember(Name = "Reserva")]
        public RetornoConsultarReservaDto Reserva { get; set; }
    }
}
