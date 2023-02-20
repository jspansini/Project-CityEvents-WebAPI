using CityEventsService.Dto;
using CityEventsService.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEventsService.Interfaces
{
    public interface IEventReservationService
    {
        Task<bool> AddReservation(EventReservDTO reserve);
        Task<IEnumerable<EventReservDTO>> ConsultReservation(string nome, string tituloEvento);
        Task<bool> RemoveReservation(int id);
        Task<bool> EditReservation(int id, int quantidade);
    }
}
