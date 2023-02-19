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


        //Inclus�o de um novo evento
        [HttpPost]
        public ActionResult<CityEventsEntitys> InsertEvent()
        {
            return Ok();
        }

        //Edi��o de um evento existente
        [HttpPut]
        public ActionResult<CityEventsEntitys> EditEvent()
        {
            return Ok();
        }

        //Remo��o de um evento
        [HttpDelete]
        public ActionResult<CityEventsEntitys> RemoveEvent()
        {
            return Ok();
        }

        //Consulta por t�tulo
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

        //Consulta por range de pre�o e a data
        [HttpGet]
        public ActionResult<CityEventsEntitys> SearchByPriceAndDate()
        {
            return Ok();
        }
    }
}