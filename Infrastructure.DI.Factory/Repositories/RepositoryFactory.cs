using Infrastructure.SqlClient.Reserva;
using Reserva.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DI.Repositories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public static RepositoryFactory Instance { get { return Singleton.inst; } }
        private class Singleton { internal static readonly RepositoryFactory inst = new RepositoryFactory(); }

        public IReservaRepository GetReservaRepository()
        {
            return new ReservaSqlRepository();
        }
    }
}
