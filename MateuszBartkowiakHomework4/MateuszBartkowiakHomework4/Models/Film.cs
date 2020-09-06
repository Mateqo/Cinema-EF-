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
    class Film
    {
        [Key]
        public int FilmId { get; set; }

        [Required]
        [DisplayName("Nazwa")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Typ")]
        public string Type { get; set; }

        [Required]
        [DisplayName("Rok produkcji")]
        public int YearOfProduction { get; set; }

        [Required]
        [DisplayName("Minimalny wiek")]
        public int MinAge { get; set; }

        [Required]
        [Column(TypeName="bit")]
        [DisplayName("Czy 3D")]
        public bool Is3D { get; set; }
    }
}
