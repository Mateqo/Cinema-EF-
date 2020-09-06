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
    public class SignIn
    {
        // Zmienna odpowiadająca czy istnieje użytkownik
        private bool isCorrect = false;
        // Deklaracja zmiennej context, potrzebna do odwołania sie do tabel
        private CinemaContext _context;

        /// <summary>
        /// Weryfikacje czy dane prawidłowe
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Check(string username, string password)
        {
            _context = new CinemaContext();

            // Sprawdzenie hasła i loginu
            var user = _context.UserLogin.Any(x => x.UserName == username && x.Password == password);

            if (user)
            {
                isCorrect = true;
            }
            else
            {
                isCorrect = false;
            }

            return isCorrect;
        }



    }
}
