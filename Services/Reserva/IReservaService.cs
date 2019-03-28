using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Services.Messages.Reserva;

namespace Services.Reserva
{
    [ServiceContract(Name = "Reserva")]
    public interface IReservaService
    {
        [OperationContract(Action = "Consultar")]
        ConsultarReservaResponse ConsultarReserva(ConsultarReservaRequest request);
        [OperationContract(Action = "Incluir")]
        IncluirReservaResponse IncluirReserva(IncluirReservaRequest request);
    }
}
