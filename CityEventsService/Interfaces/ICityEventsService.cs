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
        Task<bool> AddcEvent(CityEventDTO evento);
        Task<IEnumerable<CityEventDTO>> CheckLocalDate(string local, DateTime date);
        Task<IEnumerable<CityEventDTO>> CheckPriceDateR(decimal precoMin, decimal precoMax, DateTime data);
        Task<IEnumerable<CityEventDTO>> CheckbyTitle(string title);
        Task<bool> EditEvent(CityEventDTO evento, int id);
        Task<bool> DeletarOuInativarEvento(int id);
        Task<bool> RemoveOrDeactivate(int id);
    }
}
