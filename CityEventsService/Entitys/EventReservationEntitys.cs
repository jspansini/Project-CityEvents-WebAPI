using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEventsService.Entitys
{
    public class EventReservationEntitys
    {
        public int IdReservation { get; set; }
        public int IdEvent { get; set; }
        public string? PersonName { get; set; }
        public int Quantity { get; set; }
    }
}


