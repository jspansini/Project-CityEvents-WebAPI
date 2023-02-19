using CityEvents.Service.DTO;
using CityEventsInfraData.Repository;
using CityEventsService.Dto;
using CityEventsService.Entitys;
using CityEventsService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CityEventsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class EventReservationsController : ControllerBase
    {

        private IEventReservationService _eventReservationService { get; set; }

        public EventReservationsController(IEventReservationService eventReservationService)
        {
            _eventReservationService = eventReservationService;
        }


        //realizar reserva
        [HttpPost("MakeNewReservation")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> AdicionarReserva(EventReservDTO reserva)
        {
            if (!await _eventReservationService.AdicionarReserva(reserva))
            {
                return BadRequest();
            }
            return Ok();
        }


        

        //editar uma reserva
        [HttpPut("EditReservation")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CityEventDTO>> EditarQuantidadeReserva(int id, int quantidade)
        {
            if (!await _eventReservationService.EditarQuantidadeReserva(id, quantidade))
            {
                return BadRequest();
            }
            return Ok();
        }

        //deletar uma reserva
        [HttpDelete("DeleteReservation")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Deletar([FromQuery] int id)
        {
            if (!await _eventReservationService.DeletaReserva(id))
            {
                return BadRequest();
            }
            return NoContent();
        }


        //procurar por reserva
        [HttpGet("SearchReservationByNameAndTitle")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<EventReservDTO>>> ConsultaReserva(string nome, string tituloEvento)
        {
            return Ok(await _eventReservationService.ConsultaReserva(nome, tituloEvento));
        }
    }
}


