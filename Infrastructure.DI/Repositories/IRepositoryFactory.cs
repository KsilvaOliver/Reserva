using Reserva.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DI.Repositories
{
    public interface IRepositoryFactory
    {
        IReservaRepository GetReservaRepository();
    }
}
