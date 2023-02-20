using AutoMapper;
using CityEvents.Service.DTO;
using CityEventsService.Dto;
using CityEventsService.Entitys;
using CityEventsService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CityEventsService.Service
{
    public class CityEventService : ICityEventService
    {
        private ICityEventsRepository _repository;
        private IMapper _mapper;

        public CityEventService(ICityEventsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> AddcEvent(CityEventDTO evento)
        {
            CityEventsEntitys entidade = _mapper.Map<CityEventsEntitys>(evento);
            return await _repository.AddEvent(entidade);
        }

        public async Task<IEnumerable<CityEventDTO>> CheckLocalDate(string local, DateTime data)
        {
            IEnumerable<CityEventsEntitys> entidade = (IEnumerable<CityEventsEntitys>)await _repository.SearchBySLocaDate(local, data);
            if (entidade == null)
            {
                return null;
            }

            IEnumerable<CityEventDTO> eventoDto = _mapper.Map<IEnumerable<CityEventDTO>>(entidade);
            return eventoDto;
        }

        public async Task<IEnumerable<CityEventDTO>> CheckPriceDateR(decimal precoMin, decimal precoMax, DateTime data)
        {
            IEnumerable<CityEventsEntitys> entidade = (IEnumerable<CityEventsEntitys>)await _repository.SearchBySPriceDate(precoMin, precoMax, data);
            if (entidade == null)
            {
                return null;
            }
            IEnumerable<CityEventDTO> eventoDto = _mapper.Map<IEnumerable<CityEventDTO>>(entidade);
            return eventoDto;
        }

        public async Task<IEnumerable<CityEventDTO>> CheckbyTitle(string titulo)
        {

            IEnumerable<CityEventsEntitys> entidade = (IEnumerable<CityEventsEntitys>)await _repository.SearchBySTitle(titulo);
            if (entidade == null)
            {
                return null;
            }
            IEnumerable<CityEventDTO> eventoDto = _mapper.Map<IEnumerable<CityEventDTO>>(entidade);
            return eventoDto;
        }

        public async Task<bool> RemoveOrDeactivate(int id)
        {
            bool quantidadeReserva = await _repository.CheckReservations(id);

            if (quantidadeReserva != false)
            {
                return await _repository.DeletEvent(id);
            }
            return await _repository.InactivateEvent(id);
        }

        public async Task<bool> EditEvent(CityEventDTO evento, int id)
        {
            CityEventsEntitys entidade = _mapper.Map<CityEventsEntitys>(evento);
            return await _repository.EditEvent(entidade, id);
        }
    }
}
