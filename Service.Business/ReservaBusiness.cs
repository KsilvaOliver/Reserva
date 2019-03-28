using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Business
{
    public class ReservaBusiness
    {
        public static string MensagemRetorno(int Codigo)
        {
            string Mensagem = string.Empty;

            if (Codigo == -1)
                Mensagem = "A inclusão da reserva de margem não obteve êxito devido ao servidor encontrar-se bloqueado no sistema NConsig.";
            if (Codigo == -2)
                Mensagem = "A inclusão da reserva de margem não obteve êxito devido à margem consignável disponível para o servidor ser insuficiente.";
            if (Codigo == -3)
                Mensagem = "A inclusão da reserva de margem não obteve êxito devido ao servidor possuir o número limite de contratos para o produto selecionado.";
            if (Codigo == 0)
                Mensagem = "A inclusão da reserva de margem não obteve êxito devido a um motivo desconhecido.";
            if (Codigo > 0)
                Mensagem = "A inclusão da reserva de margem obteve êxito, o valor do retorno é o código de identificação do contrato de averbação no sistema NConsig.";


            return Mensagem;
        }
    }
}
