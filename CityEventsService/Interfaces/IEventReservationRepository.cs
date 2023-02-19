using CityEventsService.Dto;
using CityEventsService.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEventsService.Interfaces
{
    public interface IEventReservationRepository
    {
        Task<bool> AddReservation(EventReservDTO reserve);
        Task<IEnumerable<EventReservationEntitys>> ConsultReservation(string nome, string tituloEvento);
        Task<bool> DeleteReservation(int id);
        Task<bool> EditReservation(int id, int quantidade);
        Task<bool> ValidateStatus(int idEvento);
    }
}

