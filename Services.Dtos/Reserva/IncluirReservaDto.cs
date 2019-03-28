using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos.Reserva
{
    [DataContract]
    public class IncluirReservaDto
    {
        [DataMember(Name = "Token")]
        public string Token { get; set; }
        [DataMember(Name = "Cpf")]
        public string Cpf { get; set; }
        [DataMember(Name = "Matricula")]
        public string Matricula { get; set; }
        [DataMember(Name = "Senha")]
        public string Senha { get; set; }
        [DataMember(Name = "Banco")]
        public Int32 Banco { get; set; }
        [DataMember(Name = "Agencia")]
        public Int32 Agencia { get; set; }
        [DataMember(Name = "Conta")]
        public Int32 Conta { get; set; }
        [DataMember(Name = "ValorPrestacao")]
        public decimal ValorPrestacao { get; set; }
        [DataMember(Name = "ValorLiberado")]
        public decimal ValorLiberado { get; set; }
        [DataMember(Name = "QuantidadePrestacoes")]
        public Int32 QuantidadePrestacoes { get; set; }
        [DataMember(Name = "ValorTotalOperacao")]
        public decimal ValorTotalOperacao { get; set; }
    }
}
