using Services.Reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DI.Services
{
    public interface IReservaFactory
    {
        IReservaService GetReservaService();
    }
}
