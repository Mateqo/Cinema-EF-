using MateuszBartkowiakHomework4.Models;
using MateuszBartkowiakHomework4.Repositories;
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
    public partial class Ticket : Form
    {


        #region Zmienne

        CinemaContext _context;
        // Deklaracja interfejsu (by móc działać na tablei Client)
        private ICinemaGeneric<Client> _client;
        // Deklaracja interfejsu (by móc działać na tablei OrderTicket)
        private ICinemaGeneric<OrderTicket> _order;
        // Deklaracja okna place by móc się odwoływać
        public Place place;
        // Deklaracja zmiennej Imienia
        public string name="";
        // Deklaracja zmiennej Nazwisko
        public string surname="";
        // Typ biletu (normalny/ulgowy)
        public int typeOfTicket = 0;
        // Cena biletu
        public int price = 0;
        // Czy opcja Vip
        public bool vip = false;
        // Data
        public DateTime day;


        #endregion Zmienne

        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public Ticket()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor paremetryczny
        /// </summary>
        /// <param name="place"></param>
        public Ticket(Place place)
        {
            InitializeComponent();
            // Przypisanie place by móc się odwoływać 
            this.place = place;
        }

        /// <summary>
        /// Poprzednie okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxPevious_Click(object sender, EventArgs e)
        {
            this.Close();
            place.Visible = true;
        }

        /// <summary>
        /// Następne okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxNext_Click(object sender, EventArgs e)
        {
            // SPrawdzamy czy uzupełniono wszystko
            if (textBoxName.Text == "" || textBoxSurname.Text == "" ||labelTime.Text=="-")
            {
                MessageBox.Show("Nie wybrano wszystkich opcji");
            }
            else
            {
                // Przypisanie wszystkich parametrów
                this.Visible = false;
                name = textBoxName.Text;
                surname = textBoxSurname.Text;

                if(comboBoxTypeOfTicket.SelectedItem.ToString() == "Normal")
                {
                    typeOfTicket = 2;
                    price = 30;
                }

                if (comboBoxTypeOfTicket.SelectedItem.ToString() == "Student")
                {
                    typeOfTicket = 1;
                    price = 15;
                }

                day = DateTime.Parse(labelTime.Text);



                if (checkBoxVip.Checked)
                {
                    vip = true;
                }
                else
                {
                    vip = false;
                }

                // Wywołanie fuknkcji dodający rekordy do tabel
                AddClient();
                AddOrder();
                Result result = new Result(this);
                result.Show();
            }

        }

        /// <summary>
        /// Wylogowanie się
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                this.Close();
                place.film.login.Visible = true;
            }
            else
                return;
        }

        /// <summary>
        /// WYbór biletu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxTypeOfTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeOfTicket.SelectedItem.ToString() == "Normal")
                labelPrice.Text = "30";
            else if (comboBoxTypeOfTicket.SelectedItem.ToString() == "Student")
                labelPrice.Text = "15";
        }

        /// <summary>
        /// Liczenie liczby klientów
        /// </summary>
        /// <returns></returns>
        public int CountClients()
        {
            _context = new CinemaContext();
            var count = _context.Client.Count();
            return count;
        }

        /// <summary>
        /// Dodanie klienta
        /// </summary>
        public void AddClient()
        {

            // Tworzenie nowego użytkownika
            Client newClient = new Client
            {
                Name = name,
                Surname = surname,
            };

            _client = new CinemaGeneric<Client>();

            // Stworzenie i zapisanie
            _client.Create(newClient);
            _client.Save();

        }

        /// <summary>
        /// Dodanie zamówienia
        /// </summary>
        public void AddOrder()
        {
            // Tworzenie nowego użytkownika
            OrderTicket newOrder = new OrderTicket
            {
                ClientId = CountClients(),
                FilmId = place.film.film,
                TicketId = typeOfTicket,
                Day = day,
                Row = place.row,
                Place = Int32.Parse(place.place),
                Vip = vip,

            };
            
            _order = new CinemaGeneric<OrderTicket>();

            // Stworzenie i zapisanie
            _order.Create(newOrder);
            _order.Save();

    
        }


        /// <summary>
        /// Wybór godziny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimerPicker_ValueChanged(object sender, EventArgs e)
        {
            labelTime.Text = dateTimerPicker.Text;
        }

        /// <summary>
        /// Uruchomienie okna info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxInfo_Click(object sender, EventArgs e)
        {
            Account account = new Account(this);
            account.Show();
            this.Visible = false;
               
        }


    }
}
