using CityEventsService.Entitys;
using Microsoft.AspNetCore.Mvc;

namespace CityEventsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class EventReservationsController : ControllerBase
    {


        //Inclusão de uma nova reserva
        [HttpPost]
        public ActionResult<EventReservationEntitys>  MakeNewReservation()
        {
            return Ok();
        }

        //Edição da quantidade de uma reserva
        [HttpPut]
        public ActionResult<EventReservationEntitys> EditReservation()
        {
            return Ok();
        }


        //Remoção de uma reserva
        [HttpDelete]
        public ActionResult<EventReservationEntitys> DeleteReservation()
        {
            return Ok();
        }

        //Consulta de reserva pelo PersonName e Title do evento
        [HttpGet]
        public ActionResult<EventReservationEntitys> SearchReservationByNameAndTitle()
        {
            return Ok();
        }
    }
}
