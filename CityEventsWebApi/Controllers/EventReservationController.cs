using CityEventsService.Entitys;
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
        public ActionResult<EventReservationEntitys>  MakeNewReservation()
        {

        }

        //Edição da quantidade de uma reserva
        [HttpPut]
        public ActionResult<EventReservationEntitys> EditReservation()
        {

        }
        //Remoção de uma reserva
        [HttpDelete]
        public ActionResult<EventReservationEntitys> DeleteReservation()
        {

        }
        //Consulta de reserva pelo PersonName e Title do evento
        [HttpGet]
        public ActionResult<EventReservationEntitys> SearchReservationByNameAndTitle()
        {

        }
    }
}
