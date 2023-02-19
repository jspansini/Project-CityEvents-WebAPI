using Microsoft.AspNetCore.Mvc;

namespace CityEventsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class CityEventController : ControllerBase
    {


        //Inclusão de um novo evento
        [HttpPost]
        public ActionResult<CityEventEntity> InsertEvent(CityEventEntity entity)
        {

        }

        //Edição de um evento existente
        [HttpPut]
        public ActionResult<CityEventEntity> EditEvent(CityEventEntity id)
        {

        }

        //Remoção de um evento
        [HttpDelete]
        public ActionResult<CityEventEntity> RemoveEvent(CityEventEntity id)
        {

        }

        //Consulta por título
        [HttpGet]
        public ActionResult<CityEventEntity> SearchByTitle(CityEventEntity algo)
        {

        }

        //Consulta por local e data
        [HttpGet]
        public ActionResult<CityEventEntity> SearchByPlaceAndDate(CityEventEntity algo)
        {

        }

        //Consulta por range de preço e a data
        [HttpGet]
        public ActionResult<CityEventEntity> SearchByPriceAndDate(CityEventEntity algo)
        {

        }
    }
}