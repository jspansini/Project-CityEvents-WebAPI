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

        public CityEventService(ICityEventsRepository rep, IMapper mapper)
        {
            _repository = rep;
            _mapper = mapper;
        }

        public async Task<bool> AdicionarEvento(CityEventDTO evento)
        {
            CityEventsEntitys entidade = _mapper.Map<CityEventsEntitys>(evento);
            return await _repository.AdicionarEvento(entidade);
        }

        public async Task<IEnumerable<CityEventDTO>> ConsultaPorLocalEData(string local, DateTime data)
        {
            IEnumerable<CityEventsEntitys> entidade = (IEnumerable<CityEventsEntitys>)await _repository.ConsultaPorLocalEData(local, data);
            if (entidade == null)
            {
                return null;
            }

            IEnumerable<CityEventDTO> eventoDto = _mapper.Map<IEnumerable<CityEventDTO>>(entidade);
            return eventoDto;
        }

        public async Task<IEnumerable<CityEventDTO>> ConsultaPorPrecoEData(decimal precoMin, decimal precoMax, DateTime data)
        {
            IEnumerable<CityEventsEntitys> entidade = (IEnumerable<CityEventsEntitys>)await _repository.ConsultaPorPrecoEData(precoMin, precoMax, data);
            if (entidade == null)
            {
                return null;
            }
            IEnumerable<CityEventDTO> eventoDto = _mapper.Map<IEnumerable<CityEventDTO>>(entidade);
            return eventoDto;
        }

        public async Task<IEnumerable<CityEventDTO>> ConsultarPorTitulo(string titulo)
        {

            IEnumerable<CityEventsEntitys> entidade = (IEnumerable<CityEventsEntitys>)await _repository.ConsultaPorTitulo(titulo);
            if (entidade == null)
            {
                return null;
            }
            IEnumerable<CityEventDTO> eventoDto = _mapper.Map<IEnumerable<CityEventDTO>>(entidade);
            return eventoDto;
        }

        public async Task<bool> DeletarOuInativarEvento(int id)
        {
            bool quantidadeReserva = await _repository.ConsultaReservasNoEvento(id);

            if (quantidadeReserva != false)
            {
                return await _repository.ExcluirEvento(id);
            }
            return await _repository.InativarEvento(id);
        }

        public async Task<bool> EditarEvento(CityEventDTO evento, int id)
        {
            CityEventsEntitys entidade = _mapper.Map<CityEventsEntitys>(evento);
            return await _repository.EditarEvento(entidade, id);
        }
    }
}
