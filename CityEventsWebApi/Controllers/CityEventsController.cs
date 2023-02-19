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
            return;
        }

        //Edi��o de um evento existente
        [HttpPut]
        public ActionResult<CityEventsEntitys> EditEvent()
        {
            return;
        }

        //Remo��o de um evento
        [HttpDelete]
        public ActionResult<CityEventsEntitys> RemoveEvent()
        {
            return;
        }

        //Consulta por t�tulo
        [HttpGet]
        public ActionResult<CityEventsEntitys> SearchByTitle()
        {
            return;
        }

        //Consulta por local e data
        [HttpGet]
        public ActionResult<CityEventsEntitys> SearchByPlaceAndDate()
        {
            return;
        }

        //Consulta por range de pre�o e a data
        [HttpGet]
        public ActionResult<CityEventsEntitys> SearchByPriceAndDate()
        {
            return;
        }
    }
}