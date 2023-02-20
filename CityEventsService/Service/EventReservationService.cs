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

        public async Task<bool> AddReservation(EventReservDTO reserve)
        {
            bool status = await _repository.ValidaStatusEvento(reserve.IdEvent);
            if (status)
            {
                EventReservationEntitys eventReservationEntitys = _mapper.Map<EventReservationEntitys>(reserve);
                return await _repository.AddReservation(reserve);
            }
            return false;
        }


        public async Task<IEnumerable<EventReservDTO>> ConsultReservation(string nome, string tituloEvento)
        {
            IEnumerable<EventReservationEntitys> entidade = await _repository.ConsultReservation(nome, tituloEvento);
            if (entidade == null)
            {
                return null;
            }
            IEnumerable<EventReservDTO> reservaDto = _mapper.Map<IEnumerable<EventReservDTO>>(entidade);
            return reservaDto;
        }


        public async Task<bool> DeleteReservation(int id)
        {
            return await _repository.DeleteReservation(id);
        }


        public async Task<bool> EditReservation(int id, int quantidade)
        {
            return await _repository.EditReservation(id, quantidade);
        }

        public Task<bool> ValidaStatusEvento(int idEvent)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateStatus(int idEvento)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EventReservationEntitys>> IEventReservationRepository.ConsultReservation(string nome, string tituloEvento)
        {
            throw new NotImplementedException();
        }
    }
}
