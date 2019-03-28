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
    public class IncluirReservaResponse: BaseResponse
    {
        public IncluirReservaResponse()
        {
            ErrorMessages = new List<string>();
        }

        [DataMember(Name = "Retorno")]
        public RetornoIncluirReservaDto Retorno { get; set; }
    }
}
