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
        [Key]
        public long IdReservation { get; set; }

        [Required]
        [ForeignKey("IdEvent")]
        public long IdEvent { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Please fill with your full name")]
        public string PersonName { get; set; }

        public long Quantity { get; set; }
    }
}


