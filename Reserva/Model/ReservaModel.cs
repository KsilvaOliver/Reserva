using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Model
{
    public class ReservaModel
    {
        //Consulta
        public string Retorno;
        public string Cpf;
        public string Matricula;
        public string Nome;
        public DateTime DataNascimento;
        public string NomeCategoria;
        public string SituacaoServidor;
        public string Convenio;
        public string Produto;
        public decimal MargemDisponivel;
        public string ListaParcelas;

        //Inclusao
        public string Token;
        public string Senha;
        public Int32 Banco;
        public Int32 Agencia;
        public Int32 Conta;
        public decimal ValorPrestacao;
        public decimal ValorLiberado;
        public Int32 QuantidadePrestacoes;
        public decimal ValorTotalOperacao;
    }
}
