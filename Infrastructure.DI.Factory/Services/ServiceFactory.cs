using Infrastructure.DI.Repositories;
using Services.Imp.Services.Reserva;
using Services.Reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DI.Factory.Services
{
    public class ServiceFactory
    {
        public static ServiceFactory Instance { get { return Singleton.inst; } }
        private class Singleton { internal static readonly ServiceFactory inst = new ServiceFactory(); }

        internal IReservaService GetReservaService()
        {
            return new ReservaService(RepositoryFactory.Instance.GetReservaRepository());
        }
    }
}
