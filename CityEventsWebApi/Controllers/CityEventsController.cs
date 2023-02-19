using CityEvents.Service.DTO;
using CityEventsInfraData.Repository;
using CityEventsService.Dto;
using CityEventsService.Entitys;
using CityEventsService.Interfaces;
using CityEventsService.Service;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CityEventsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class CityEventController : ControllerBase
    {

        private readonly ICityEventService _cityEventsService;


        public CityEventController(ICityEventService cityEventsService)
        {
            _cityEventsService = cityEventsService;
        }


        //deletar referencia richard
        ////private ICityEventService _cityEventService { get; set; }
        ////public CityEventsController(ICityEventService cityEventService)
        ////{
        ////    _cityEventService = cityEventService;
        ////}


        //INCLUIR
        [HttpPost("InsertEvents")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CityEventDTO>> Inserir(CityEventDTO entity)
        {
            if (!await _cityEventsService.AdicionarEvento(entity))
            {
                return BadRequest();
            }
            return Ok(entity);
        }

        //EDITAR
        [HttpPut("EditEvents")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CityEventDTO>> EditarEvento(CityEventDTO entity, int id)
        {
            if (!await _cityEventsService.EditarEvento(entity, id))
            {
                return BadRequest();
            }
            return Ok(entity);
        }

        //DELETAR
        [HttpDelete("DeleteEvents")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Deletar([FromQuery] int id)
        {

            if (!await _cityEventsService.DeletarOuInativarEvento(id))
            {
                return BadRequest();
            }
            return NoContent();
        }



        //CONSULTAPORTITULO
        [HttpGet("SearchByTitle")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<CityEventDTO> GetConsultaPorTitulo(string titulo)
        {
            return Ok(_cityEventsService.ConsultarPorTitulo(titulo));
        }


        //CONSULTA POR LUGAR E DATA
        [HttpGet("SearchByPlaceAndDate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<CityEventDTO> GetConsultaPorLocalEData(string local, DateTime data)
        {
            return Ok(_cityEventsService.ConsultaPorLocalEData(local, data));
        }

        //CONSULTA POR PREÇO E DATA
        [HttpGet("SearchByPriceAndDate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<CityEventDTO> GetConsultaPorPrecoData(decimal precoMin, decimal precoMax, DateTime data)
        {
            return Ok(_cityEventsService.ConsultaPorPrecoEData(precoMin, precoMax, data));
        }

 

       
  
        

        
       
        
    }
}



//[HttpGet("ConsultaPorLocalEData")]
//[ProducesResponseType(StatusCodes.Status200OK)]
//public ActionResult<CityEventsEntity> GetConsultaPorLocalEData(string local, DateTime data)
//{
//    return Ok(_cityEventRepository.ConsultaPorLocalEData(local, data));
//}

//[HttpGet("ConsultaPorTitulo")]
//[ProducesResponseType(StatusCodes.Status200OK)]
//public ActionResult<CityEventsEntity> GetConsultaPorTitulo(string titulo)
//{
//    return Ok(_cityEventRepository.ConsultaPorTitulo(titulo));
//}


//[HttpPut]
//[ProducesResponseType(StatusCodes.Status201Created)]
//[ProducesResponseType(StatusCodes.Status400BadRequest)]
//public ActionResult<CityEventsEntity> EditarEvento(CityEventsEntity entity, int id)
//{
//    if (!_cityEventRepository.EditarEvento(entity, id))
//    {
//        return BadRequest();
//    }
//    return Ok(entity);
//}