using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos.Reserva
{
    public class RetornoConsultarReservaDto
    {
        [DataMember(Name = "Retorno")]
        public string Retorno { get; set; }
        [DataMember(Name = "Cpf")]
        public string Cpf { get; set; }
        [DataMember(Name = "Matricula")]
        public string Matricula { get; set; }
        [DataMember(Name = "Nome")]
        public string Nome { get; set; }
        [DataMember(Name = "DataNascimento")]
        public DateTime DataNascimento { get; set; }
        [DataMember(Name = "NomeCategoria")]
        public string NomeCategoria { get; set; }
        [DataMember(Name = "SituacaoServidor")]
        public string SituacaoServidor { get; set; }
        [DataMember(Name = "Convenio")]
        public string Convenio { get; set; }
        [DataMember(Name = "Produto")]
        public string Produto { get; set; }
        [DataMember(Name = "MargemDisponivel")]
        public decimal MargemDisponivel { get; set; }
        [DataMember(Name = "ListaParcelas")]
        public string ListaParcelas { get; set; }
    }
}
