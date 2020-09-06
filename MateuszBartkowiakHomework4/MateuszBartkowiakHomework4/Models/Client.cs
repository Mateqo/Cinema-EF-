using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszBartkowiakHomework4.Models
{
    class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        [DisplayName("Imię")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Nazwisko")]
        public string Surname { get; set; }
    }
}
