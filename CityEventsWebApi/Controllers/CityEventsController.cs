using Microsoft.AspNetCore.Mvc;

namespace CityEventsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class CityEventController : ControllerBase
    {


        //Inclus�o de um novo evento
        [HttpPost]
        public ActionResult<CityEventEntity> InsertEvent(CityEventEntity entity)
        {

        }

        //Edi��o de um evento existente
        [HttpPut]
        public ActionResult<CityEventEntity> EditEvent(CityEventEntity id)
        {

        }

        //Remo��o de um evento
        [HttpDelete]
        public ActionResult<CityEventEntity> RemoveEvent(CityEventEntity id)
        {

        }

        //Consulta por t�tulo
        [HttpGet]
        public ActionResult<CityEventEntity> SearchByTitle(CityEventEntity algo)
        {

        }

        //Consulta por local e data
        [HttpGet]
        public ActionResult<CityEventEntity> SearchByPlaceAndDate(CityEventEntity algo)
        {

        }

        //Consulta por range de pre�o e a data
        [HttpGet]
        public ActionResult<CityEventEntity> SearchByPriceAndDate(CityEventEntity algo)
        {

        }
    }
}