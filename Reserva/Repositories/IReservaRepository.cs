using Reserva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Repositories
{
    public interface IReservaRepository
    {
        ReservaModel Consultar(string Token, string Cpf, string Matricula, string senha);
        Int32 Incluir(ReservaModel Reserva);
    }
}
