using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEventsService.Entitys
{
    public class CityEventsEntitys
    {
        public int IdEvent { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateHourEvent { get; set; }
        public string Local { get; set; }
        public string Address { get; set; }
        public Decimal Price { get; set; }
        public bool Status { get; set; }
    }
}
