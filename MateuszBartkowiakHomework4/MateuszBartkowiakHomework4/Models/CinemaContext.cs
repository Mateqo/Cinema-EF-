using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszBartkowiakHomework4.Models
{
    class CinemaContext : DbContext
    {
        public CinemaContext() : base ("AppContext")
        {

        }

        public virtual DbSet<UserLogin> UserLogin { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<OrderTicket> OrderTicket { get; set; }


    }
}
