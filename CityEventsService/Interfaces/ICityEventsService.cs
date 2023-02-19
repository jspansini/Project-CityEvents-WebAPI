using CityEvents.Service.DTO;
using CityEventsService.Dto;
using CityEventsService.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEventsService.Interfaces
{
    public interface ICityEventService

    {
        Task<bool> AdicionarEvento(CityEventDTO evento);
        Task<IEnumerable<CityEventDTO>> ConsultaPorLocalEData(string local, DateTime data);
        Task<IEnumerable<CityEventDTO>> ConsultaPorPrecoEData(decimal precoMin, decimal precoMax, DateTime data);
        Task<IEnumerable<CityEventDTO>> ConsultarPorTitulo(string titulo);
        Task<bool> EditarEvento(CityEventDTO evento, int id);
        Task<bool> DeletarOuInativarEvento(int id);
    }
}
