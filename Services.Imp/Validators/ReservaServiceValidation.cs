using Services.Messages.Reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Imp.Validators
{
    public static class ReservaServiceValidation
    {
        public static ConsultarReservaResponse Validate(this ConsultarReservaRequest request)
        {
            var response = new ConsultarReservaResponse();

            if (string.IsNullOrEmpty(request.Token))
                response.ErrorMessages.Add("Token: Obrigatório");

            if (string.IsNullOrEmpty(request.Cpf))
                response.ErrorMessages.Add("CPF: Obrigatório");

            if (string.IsNullOrEmpty(request.Matricula))
                response.ErrorMessages.Add("Matricula: Obrigatória");

            if (string.IsNullOrEmpty(request.Senha))
                response.ErrorMessages.Add("Senha: Obrigatória");

            if (response.ErrorMessages.Count() > 0)
                response.Error = true;

            return response;
        }

        public static IncluirReservaResponse Validate(this IncluirReservaRequest request)
        {
            var response = new IncluirReservaResponse();

            if (request == null)
            {
                response.ErrorMessages.Add("Invalid Request!");
            }
            else
            { 
                if (string.IsNullOrEmpty(request.Reserva.Token))
                    response.ErrorMessages.Add("Token: Obrigatório");

                if (string.IsNullOrEmpty(request.Reserva.Cpf))
                    response.ErrorMessages.Add("CPF: Obrigatório");

                if (string.IsNullOrEmpty(request.Reserva.Matricula))
                    response.ErrorMessages.Add("Matricula: Obrigatória");

                if (string.IsNullOrEmpty(request.Reserva.Senha))
                    response.ErrorMessages.Add("Senha: Obrigatória");

                if (ToGenericValue<Int32>(request.Reserva.Banco) == 0)
                    response.ErrorMessages.Add("Banco: Campo inválido");

                if (ToGenericValue<Int32>(request.Reserva.Agencia) == 0)
                    response.ErrorMessages.Add("Agencia: Campo inválido");

                if (ToGenericValue<Int32>(request.Reserva.Conta) == 0)
                    response.ErrorMessages.Add("Conta: Campo inválido");

                if (ToGenericValue<decimal>(request.Reserva.ValorPrestacao) == 0)
                    response.ErrorMessages.Add("Valor da Prestação: Campo inválido");

                if (ToGenericValue<decimal>(request.Reserva.ValorLiberado) == 0)
                    response.ErrorMessages.Add("Valor Liberado: Campo inválido");

                if (ToGenericValue<Int32>(request.Reserva.QuantidadePrestacoes) == 0)
                    response.ErrorMessages.Add("Quantidade de Prestações: Campo inválido");

                if (ToGenericValue<decimal>(request.Reserva.ValorTotalOperacao) == 0)
                    response.ErrorMessages.Add("Valor Total da Operação: Campo inválido");
            }

            if (response.ErrorMessages.Count() > 0)
                response.Error = true;

            return response;
        }

        public static T ToGenericValue<T>(T Field)
        {
            var tipoPropriedade = typeof(T);

            return Field != null ?
                (T)(
                    tipoPropriedade.IsEnum ?
                    Enum.Parse(tipoPropriedade, Field.ToString()) :
                    Field
                ) :
                default(T);
        }
    }
}
