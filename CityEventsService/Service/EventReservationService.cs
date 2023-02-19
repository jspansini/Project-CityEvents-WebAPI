using AutoMapper;
using CityEventsService.Dto;
using CityEventsService.Entitys;
using CityEventsService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEventsService.Service
{
    public class EventReservationService : IEventReservationRepository
    {
        private IEventReservationRepository _repository;
        private IMapper _mapper;

        public EventReservationService(IEventReservationRepository rep, IMapper mapper)
        {
            _repository = rep;
            _mapper = mapper;
        }



     
        public async Task<bool> AdicionarReserva(EventReservDTO reserve)
        {
            bool status = await _repository.ValidaStatusEvento(reserve.IdEvent);
            if (status)
            {
                EventReservationEntitys eventReservationEntitys = _mapper.Map<EventReservationEntitys>(reserve);
                return await _repository.AdicionarReserva(reserve);
            }
            return false;
        }


        public async Task<IEnumerable<EventReservDTO>> ConsultaReserva(string nome, string tituloEvento)
        {
            IEnumerable<EventReservationEntitys> entidade = await _repository.ConsultaReserva(nome, tituloEvento);
            if (entidade == null)
            {
                return null;
            }
            IEnumerable<EventReservDTO> reservaDto = _mapper.Map<IEnumerable<EventReservDTO>>(entidade);
            return reservaDto;
        }


        public async Task<bool> DeletaReserva(int id)
        {
            return await _repository.DeletaReserva(id);
        }


        public async Task<bool> EditarQuantidadeReserva(int id, int quantidade)
        {
            return await _repository.EditarQuantidadeReserva(id, quantidade);
        }

        public Task<bool> ValidaStatusEvento(int idEvento)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EventReservationEntitys>> IEventReservationRepository.ConsultaReserva(string nome, string tituloEvento)
        {
            throw new NotImplementedException();
        }
    }
}
