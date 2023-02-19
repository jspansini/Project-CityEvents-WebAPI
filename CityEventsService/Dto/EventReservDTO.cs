using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEventsService.Dto
{
    public class EventReservDTO
    {
        [Required(ErrorMessage = "The ID is necessary!")]
        [Range(1, int.MaxValue, ErrorMessage = "Cant be null")]
        public int IdEvent { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The name is necessary")]
        [MaxLength(100)]
        public string PersonName { get; set; }

        [Required(ErrorMessage = "Please inform how many you want")]
        [Range(1, 50, ErrorMessage = "Between 1 and 50")]
        public int Quantity { get; set; }
    }
}
