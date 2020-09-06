using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszBartkowiakHomework4.Models
{
    class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [Required]
        [DisplayName("Rodzaj zniżki")]
        public string Discount { get; set; }

        [Required]
        [DisplayName("Cena")]
        public int Price { get; set; }

    }
}
