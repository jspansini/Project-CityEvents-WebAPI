using CityEventsService.Dto;
using CityEventsService.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEventsService.Interfaces
{
    public interface ICityEventsRepository
    {
        Task<bool> AdicionarEvento(CityEventsEntitys evento);

        Task<bool> EditarEvento(CityEventsEntitys evento, int id);

        Task<bool> ExcluirEvento(int id);

        Task<bool> InativarEvento(int id);

        Task<List<CityEventsEntitys>> ConsultaPorTitulo(string titulo);

        Task<IEnumerable<CityEventsEntitys>> ConsultaPorLocalEData(string local, DateTime data);

        Task<List<CityEventsEntitys>> ConsultaPorPrecoEData(decimal precoMin, decimal precoMax, DateTime data);
        Task<bool> ConsultaReservasNoEvento(int idEvento);
    }
}
