using MateuszBartkowiakHomework4.Models;
using MateuszBartkowiakHomework4.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszBartkowiakHomework4
{
    class RegisterAccount
    {

        // Deklaracja interfejsu (by móc działać na tablei UserLogin)
        private ICinemaGeneric<UserLogin> _user;
        // Deklaracja zmiennej mówiącej o ty czy nazwa jest wolna
        private bool loginFree = false;

        // Deklaracja zmiennej context, potrzebna do odwołania sie do tabel
        private CinemaContext _context;

        /// <summary>
        /// Sprawdzanie dostępności nazwy użytkownika
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool IsFree(string username)
        {
            _context = new CinemaContext();

            // Czy taka nazwa istnieje 
            var user = _context.UserLogin.Any(x => x.UserName == username);

            if(user)
            {
                loginFree = false;
            }
            else
            {
                loginFree = true;
            }


            return loginFree;
        }

        /// <summary>
        /// Dodanie nowego użytkownika
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public void AddNewAccount(string login,string password)
        {

            // Tworzenie nowego użytkownika
            UserLogin newUser = new UserLogin
            {
                UserName = login,
                Password = password,
            };

            _user = new CinemaGeneric<UserLogin>();

            // Stworzenie i zapisanie
            _user.Create(newUser);
            _user.Save();

        }

    }
}
