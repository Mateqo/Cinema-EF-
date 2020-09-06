using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszBartkowiakHomework4.Models
{
    class OrderTicket
    {
        [Key]
        public int OrderTIcketId { get; set; }

        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        public int FilmId { get; set; }

        [ForeignKey("FilmId")]
        public virtual Film Film { get; set; }

        public int TicketId { get; set; }

        [ForeignKey("TicketId")]
        public virtual Ticket Ticket { get; set; }

        [Required]
        [DisplayName("Data")]
        public DateTime Day { get; set; }


        [Required]
        [DisplayName("Rząd")]
        public string Row { get; set; }

        [Required]
        [DisplayName("Miejsce")]
        public int Place { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        [DisplayName("Opcja vip")]
        public bool Vip { get; set; }
    }
}
