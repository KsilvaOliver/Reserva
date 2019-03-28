using Reserva.Repositories;
using Services.Mappers.Reserva;
using Services.Messages.Reserva;
using Services.Reserva;
using System;
using Services.Imp.Validators;
using Service.Business;
using Services.Dtos.Reserva;

namespace Services.Imp.Services.Reserva
{
    public class ReservaService: IReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository)
        {
            this._reservaRepository = reservaRepository;
        }


        public ConsultarReservaResponse ConsultarReserva(ConsultarReservaRequest request)
        {
            var response = new ConsultarReservaResponse();  
            try
            {
                response = request.Validate();

                if(!response.Error)
                    response.Reserva = ReservaMapper.MapperToConsultaDto(_reservaRepository.Consultar(request.Token, request.Cpf, request.Matricula, request.Senha));
            }
            catch (Exception ex)
            {
                response.Error = true;
                response.ErrorMessages.Add(ex.Message);
            }
           
            return response;
        }

        public IncluirReservaResponse IncluirReserva(IncluirReservaRequest request)
        {
            var response = new IncluirReservaResponse();
            var retorno = new RetornoIncluirReservaDto();
            
            try
            {
                response = request.Validate();

                if (!response.Error)
                    response.Retorno = ReservaMapper.MapperToIncluirDto(_reservaRepository.Incluir(ReservaMapper.Mapper(request.Reserva)));
                
            }
            catch(Exception ex)
            {
                response.Error = true;
                response.ErrorMessages.Add(ex.Message);
            }

            return response;
        }
    }
}
