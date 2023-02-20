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
        Task<bool> AddEvent(CityEventsEntitys evento);

        Task<bool> EditEvent(CityEventsEntitys evento, int id);

        Task<bool> DeletEvent(int id);

        Task<bool> InactivateEvent(int id);

        Task<List<CityEventsEntitys>> SearchBySTitle(string titulo);

        Task<IEnumerable<CityEventsEntitys>> SearchBySLocaDate(string local, DateTime data);

        Task<List<CityEventsEntitys>> SearchBySPriceDate(decimal precoMin, decimal precoMax, DateTime data);

        Task<bool> CheckReservations(int idEvento);
    }
}
