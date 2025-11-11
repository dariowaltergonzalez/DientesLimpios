using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DientesLimpios.Aplicacion.Utilidades.Mediador
{
    public interface IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    {
        Task<TResponse> Handle(TRequest request);
    }

    //se corresponse a un caso de uso el cual no retorna nada
    public interface IRequestHandler<TRequest>
    where TRequest : IRequest
    {
        Task Handle(TRequest request);
    }
}
