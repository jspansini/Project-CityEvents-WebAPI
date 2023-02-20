using CityEvents.Service.DTO;
using CityEventsInfraData.Repository;
using CityEventsService.Dto;
using CityEventsService.Entitys;
using CityEventsService.Interfaces;
using CityEventsService.Service;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using static CityEvents.Filter.FilterExceptions;

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

        [HttpPost("InsertEvents")]
        [TypeFilter(typeof(GeneralExcepetionFilter))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CityEventDTO>> InsertEvents(CityEventDTO entity)
        {
            if (!await _cityEventsService.AddcEvent(entity))
            {
                return BadRequest();
            }
            return Ok(entity);
        }


        [HttpPut("EditEvents")]
        [TypeFilter(typeof(GeneralExcepetionFilter))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CityEventDTO>> EditarEvento(CityEventDTO entity, int id)
        {
            if (!await _cityEventsService.EditEvent(entity, id))
            {
                return BadRequest();
            }
            return Ok(entity);
        }


        [HttpDelete("DeleteEvents")]
        [TypeFilter(typeof(GeneralExcepetionFilter))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Deletar([FromQuery] int id)
        {

            if (!await _cityEventsService.RemoveOrDeactivate(id))
            {
                return BadRequest();
            }
            return NoContent();
        }


        [HttpGet("SearchByTitle")]
        [TypeFilter(typeof(GeneralExcepetionFilter))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<CityEventDTO> SearchByTitle(string title)
        {
            if (title == null) 
                return BadRequest();
            return Ok(_cityEventsService.CheckbyTitle(title));
        
        }

   
        [HttpGet("SearchByPlaceAndDate")]
        [TypeFilter(typeof(GeneralExcepetionFilter))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<CityEventDTO> SearchByPlaceAndDate(string local, DateTime data)
        {
            return Ok(_cityEventsService.CheckLocalDate(local, data));
        }

        
        [HttpGet("SearchByPriceAndDate")]
        [TypeFilter(typeof(GeneralExcepetionFilter))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<CityEventDTO> SearchByPriceAndDate(decimal minimumPrice, decimal maximumPrice, DateTime data)
        {
            return Ok(_cityEventsService.CheckPriceDateR(minimumPrice, maximumPrice, data));
        }

 

       
  
        

        
       
        
    }
}