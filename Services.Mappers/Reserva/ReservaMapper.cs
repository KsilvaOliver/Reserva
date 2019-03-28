using Reserva.Model;
using Service.Business;
using Services.Dtos.Reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mappers.Reserva
{
    public class ReservaMapper
    {
        public static RetornoConsultarReservaDto MapperToConsultaDto(ReservaModel reserva)
        {
            if (reserva == null)
                return null;

            return new RetornoConsultarReservaDto
            {
                Retorno = reserva.Retorno,
                Cpf = reserva.Cpf,
                Matricula = reserva.Matricula,
                Nome = reserva.Nome,
                DataNascimento = reserva.DataNascimento,
                NomeCategoria = reserva.NomeCategoria,
                SituacaoServidor = reserva.SituacaoServidor,
                Convenio = reserva.Convenio,
                Produto = reserva.Produto,
                MargemDisponivel = reserva.MargemDisponivel,
                ListaParcelas= reserva.ListaParcelas
            };  
        }

        public static ReservaModel Mapper(IncluirReservaDto reserva)
        {
            if (reserva == null)
                return null;

            return new ReservaModel
            {
                Token = reserva.Token,
                Cpf = reserva.Cpf,
                Matricula = reserva.Matricula,
                Senha = reserva.Senha,
                Banco = reserva.Banco,
                Agencia = reserva.Agencia,
                Conta = reserva.Conta,
                ValorPrestacao = reserva.ValorPrestacao,
                ValorLiberado = reserva.ValorLiberado,
                QuantidadePrestacoes = reserva.QuantidadePrestacoes,
                ValorTotalOperacao = reserva.ValorTotalOperacao
            };
        }


        public static RetornoIncluirReservaDto MapperToIncluirDto(Int32 codigo)
        {
            Int32 _codigo;
            Int32.TryParse(codigo.ToString(), out _codigo);

            if (codigo == 0)
                return null;

            return new RetornoIncluirReservaDto()
            {
                Codigo = codigo,
                Mensagem = ReservaBusiness.MensagemRetorno(codigo)
            };
        }
    }
}
