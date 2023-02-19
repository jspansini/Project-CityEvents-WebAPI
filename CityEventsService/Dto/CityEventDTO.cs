using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEvents.Service.DTO
{
    public class CityEventDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "The title is necessary!")]
        [MaxLength(100)]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "The date is necessary!")]
        public DateTime DateHourEvent { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The location is necessary!")]
        [MaxLength(100)]
        public string Local { get; set; }

        [MaxLength(150)]
        public string? Address { get; set; }

        [Required]
        public Decimal Price { get; set; }
        public bool Status { get; set; }
    }
}
