using Services.Messages.Reserva;
using Services.Reserva;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using WebApi.Binding;

namespace WebApi.Controllers.Reserva
{
    public class ReservaController: ApiController
    {
        private readonly IReservaService ReservarTaskService;

        public ReservaController(IReservaService _reservarTaskService)
        {
            this.ReservarTaskService = _reservarTaskService;
        }

        [HttpGet]
        [Route("Reserva/ConsutarReserva")]
        public ConsultarReservaResponse ConsultarReserva([ModelBinder(typeof(ConsultaBinding))]ConsultarReservaRequest request)
        {
            return ReservarTaskService.ConsultarReserva(request);
        }

        [HttpPost]
        [Route("Incluir/IncluirReserva")]
        public IncluirReservaResponse IncluirReserva([FromBody]IncluirReservaRequest request)
        {
            return ReservarTaskService.IncluirReserva(request);
        }
    }
}