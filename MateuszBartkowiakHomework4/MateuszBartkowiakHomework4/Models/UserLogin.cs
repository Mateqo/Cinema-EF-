using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszBartkowiakHomework4.Models
{
    class UserLogin
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [DisplayName("Nazwa użytkownika")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Hasło")]
        public string Password { get; set; }
    }
}
