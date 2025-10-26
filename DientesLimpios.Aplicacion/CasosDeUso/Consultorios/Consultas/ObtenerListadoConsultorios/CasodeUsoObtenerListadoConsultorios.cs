using DientesLimpios.Aplicacion.Contratos.Repositorios;
using DientesLimpios.Aplicacion.Utilidades.Mediador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DientesLimpios.Aplicacion.CasosDeUso.Consultorios.Consultas.ObtenerListadoConsultorios
{
    public class CasodeUsoObtenerListadoConsultorios : IRequestHandler<ConsultaObtenerListadoConsultorios,
                                                            List<ConsultorioListadoDTO>>
    {
        private readonly IRepositorioConsultorios repositorio;

        public CasodeUsoObtenerListadoConsultorios(IRepositorioConsultorios repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task<List<ConsultorioListadoDTO>> Handle(ConsultaObtenerListadoConsultorios request)
        {
            var consultorios = await repositorio.ObtenerTodos();
            var consultoriosDTO = consultorios.Select(c => c.ADto()).ToList();
            return consultoriosDTO;
        }
    }
}
