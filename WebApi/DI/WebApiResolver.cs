using Infrastructure.DI.Factory.Services;
using Infrastructure.DI.Services;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using WebApi.Controllers.Reserva;

namespace WebApi.DI
{
    public class WebApiResolver: IDependencyResolver
    {
        private readonly IReservaFactory _factory;
        private readonly static ConcurrentDictionary<Type, Func<object>> cacheTypes = new ConcurrentDictionary<Type, Func<object>>();

        public WebApiResolver(IReservaFactory factory)
        {
            if (cacheTypes.IsEmpty)
            {
                this._factory = factory;
                cacheTypes.TryAdd(typeof(ReservaController), () => new ReservaController(factory.GetReservaService()));
            }
        }

        public IReservaFactory Factory
        {
            get { return _factory; }
        }

        public IDependencyScope BeginScope()
        {
            return new WebApiResolver(ReservaFactory.Instance);
        }

        public object GetService(Type serviceType)
        {
            Func<object> func = null;
            if (cacheTypes.TryGetValue(serviceType, out func))
            {
                return func();
            }

            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }

        public void Dispose()
        {
        }
    }
}