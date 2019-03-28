using Infrastructure.DI.Services;
using Services.Reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DI.Factory.Services
{
    public class ReservaFactory: IReservaFactory
    {
        public static ReservaFactory Instance { get; private set; }

        static ReservaFactory()
        {
            Instance = new ReservaFactory();
        }

        public IReservaService GetReservaService()
        {
            return ServiceFactory.Instance.GetReservaService();
        }
    }
}
