using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Services.Messages.Reserva
{
    public class ConsultarReservaRequest
    {
        [DataMember(Name = "Token")]
        public string Token { get; set; }
        [DataMember(Name = "Cpf")]
        public string Cpf { get; set; }
        [DataMember(Name = "Matricula")]
        public string Matricula { get; set; }
        [DataMember(Name = "Senha")]
        public string Senha { get; set; }
    }
}
