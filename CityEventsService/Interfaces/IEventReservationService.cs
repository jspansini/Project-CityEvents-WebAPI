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
        Task<bool> AdicionarReserva(EventReservDTO reserva);
        Task<IEnumerable<EventReservDTO>> ConsultaReserva(string nome, string tituloEvento);
        Task<bool> DeletaReserva(int id);
        Task<bool> EditarQuantidadeReserva(int id, int quantidade);
    }
}
