using Microsoft.AspNetCore.Mvc;

namespace CityEventsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class EventReservationController : ControllerBase
    {


        //Inclusão de uma nova reserva
        [HttpPost]
        public ActionResult<EventReservationEntity>  MakeNewReservation()
        {

        }

        //Edição da quantidade de uma reserva
        [HttpPut]
        public ActionResult<EventReservationEntity> EditReservation()
        {

        }
        //Remoção de uma reserva
        [HttpDelete]
        public ActionResult<EventReservationEntity> DeleteReservation()
        {

        }
        //Consulta de reserva pelo PersonName e Title do evento
        [HttpGet]
        public ActionResult<EventReservationEntity> SearchReservationByNameAndTitle()
        {

        }
    }
}
