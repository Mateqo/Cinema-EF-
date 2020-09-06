using MateuszBartkowiakHomework4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszBartkowiakHomework4
{
    public partial class Account : Form
    {
        // Deklaracja zmiennej context, potrzebna do odwołania sie do tabel
        private CinemaContext _context;
        // Dodanie klasy by użyć metody sprawdz czy istnieje login 
        RegisterAccount register = new RegisterAccount();
        // Deklaracja zmiennej by móc sie odwołać
        FilmSelect film;
        // Deklaracja zmiennej by móc sie odwołać
        Place place;
        // Deklaracja zmiennej by móc sie odwołać
        Ticket ticket;
        // Deklaracja zmiennej by móc sie odwołać
        Result result;
        // Deklaracja zmiennej określająca co zmieniamy
        bool changeLogin = true;
        // Deklaracja zmiennej przechowująca które okno wywołało
        string form ="";
        

        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public Account()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        /// <param name="film"></param>
        public Account(FilmSelect film)
        {
            InitializeComponent();
            // Przypisanie by móc się odwoływać
            this.film = film;
            labelLogin.Text = film.login.login;
            form = "film";
        }

        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        /// <param name="film"></param>
        public Account(Place place)
        {
            InitializeComponent();
            // Przypisanie by móc się odwoływać
            this.place = place;
            labelLogin.Text = place.film.login.login;
            form = "place";
        }

        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        /// <param name="film"></param>
        public Account(Ticket ticket)
        {
            InitializeComponent();
            // Przypisanie by móc się odwoływać
            this.ticket = ticket;
            labelLogin.Text = ticket.place.film.login.login;
            form = "ticket";
        }

        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        /// <param name="film"></param>
        public Account(Result result)
        {
            InitializeComponent();
            // Przypisanie by móc się odwoływać
            this.result = result;
            labelLogin.Text = result.ticket.place.film.login.login;
            form = "result";
        }

        /// <summary>
        /// Wylogowanie się 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
                this.Close();
                switch (form)
                {
                    case "film":
                        film.Visible = true;
                        break;
                    case "place":
                        place.Visible = true;
                        break;
                    case "ticket":
                        ticket.Visible = true;
                        break;
                    case "result":
                        result.Visible = true;
                        break;
                }
        }

        /// <summary>
        /// Pojawienie się miejsca na zmiane loginu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeLogin_Click(object sender, EventArgs e)
        {
            textBoxLogin.Visible = true;
            textBoxPassword.Visible = false;
            buttonConfirm.Visible = true;
            changeLogin = true;
        }

        /// <summary>
        /// Pojawienie się miejsca na zmiane hasła
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Visible = true;
            textBoxLogin.Visible = false;
            buttonConfirm.Visible = true;
            changeLogin = false;
        }

        /// <summary>
        /// Potwierdzenie zmiany danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Nie podano żadnych zmian");
            }
            else
            {
                if (changeLogin == true)
                {
                    if (register.IsFree(textBoxLogin.Text))
                    {

                        textBoxPassword.Visible = false;
                        textBoxPassword.Visible = false;
                        buttonConfirm.Visible = false;


                        ChangeAccount(labelLogin.Text,textBoxLogin.Text,textBoxPassword.Text);
                        labelLogin.Text = textBoxLogin.Text;

                        MessageBox.Show("Dane zmienione pomyślnie");
                    }
                    else
                        MessageBox.Show("Nazwa użytkonika zajęta");
                }
                else
                {
                    textBoxPassword.Visible = false;
                    textBoxPassword.Visible = false;
                    buttonConfirm.Visible = false;


                    ChangeAccount(labelLogin.Text, textBoxLogin.Text, textBoxPassword.Text);


                    MessageBox.Show("Dane zmienione pomyślnie");
                }

            }
        }

        /// <summary>
        /// Funkcja odpowiadająca za zmianę danych
        /// </summary>
        private void ChangeAccount(string currentLogin, string newLogin,string newPassword)
        {

            _context = new CinemaContext();

            // Wyciąga rekord o takim loginie
            var user = _context.UserLogin.FirstOrDefault(x => x.UserName == currentLogin);

            // Zmiana 
            if (changeLogin)
                user.UserName = newLogin;
            else
                user.Password = newPassword;

            // Zapis
            _context.SaveChanges();
        }

    }
}
