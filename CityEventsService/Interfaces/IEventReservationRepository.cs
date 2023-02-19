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

        Task<bool> AdicionarReserva(EventReservDTO reserve);
        Task<IEnumerable<EventReservationEntitys>> ConsultaReserva(string nome, string tituloEvento);
        Task<bool> DeletaReserva(int id);
        Task<bool> EditarQuantidadeReserva(int id, int quantidade);

        Task<bool> ValidaStatusEvento(int idEvento);
    }
}

