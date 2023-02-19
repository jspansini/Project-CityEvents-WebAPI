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
        [Key]
        public long IdEvent { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "Please, fill the Date-Hour in this format: day/month/year hour:minut")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime DateHourEvent { get; set; }

        [Required]
        public string Local { get; set; }

        public string? Address { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}
