using CityEventsService.Entitys;
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
        public ActionResult<CityEventsEntitys> InsertEvent()
        {
            return Ok();
        }

        //Edição de um evento existente
        [HttpPut]
        public ActionResult<CityEventsEntitys> EditEvent()
        {
            return Ok();
        }

        //Remoção de um evento
        [HttpDelete]
        public ActionResult<CityEventsEntitys> RemoveEvent()
        {
            return Ok();
        }

        //Consulta por título
        [HttpGet]
        public ActionResult<CityEventsEntitys> SearchByTitle()
        {
            return Ok();
        }

        //Consulta por local e data
        [HttpGet]
        public ActionResult<CityEventsEntitys> SearchByPlaceAndDate()
        {
            return Ok();
        }

        //Consulta por range de preço e a data
        [HttpGet]
        public ActionResult<CityEventsEntitys> SearchByPriceAndDate()
        {
            return Ok();
        }
    }
}