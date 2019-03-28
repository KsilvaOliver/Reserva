using Services.Messages.Reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace WebApi.Binding
{
    public class ConsultaBinding : IModelBinder
    {
        public bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType == typeof(ConsultarReservaRequest))
            {
                var parametros = HttpUtility.ParseQueryString(actionContext.Request.RequestUri.Query);

                var request = new ConsultarReservaRequest()
                {
                    Token = parametros["Token"],
                    Cpf = parametros["Cpf"],
                    Matricula = parametros["Matricula"],
                    Senha = parametros["Senha"]
                };
                bindingContext.Model = request;
                return true;
            }
            bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Cannot convert value to Location");
            return false;
        }
    }
}