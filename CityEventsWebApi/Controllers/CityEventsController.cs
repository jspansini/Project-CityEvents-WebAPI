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
            return;
        }

        //Edição de um evento existente
        [HttpPut]
        public ActionResult<CityEventsEntitys> EditEvent()
        {
            return;
        }

        //Remoção de um evento
        [HttpDelete]
        public ActionResult<CityEventsEntitys> RemoveEvent()
        {
            return;
        }

        //Consulta por título
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

        //Consulta por range de preço e a data
        [HttpGet]
        public ActionResult<CityEventsEntitys> SearchByPriceAndDate()
        {
            return;
        }
    }
}