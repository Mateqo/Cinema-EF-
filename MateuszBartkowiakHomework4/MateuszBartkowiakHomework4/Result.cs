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
    public partial class Result : Form
    {
        CinemaContext _context;
        private ICinemaGeneric<OrderTicket> _order;
        private ICinemaGeneric<Client> _client;
        // Zmienna okna ticket
        public Ticket ticket;

        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public Result()
        {
            InitializeComponent();
            _order = new CinemaGeneric<OrderTicket>();
            _client = new CinemaGeneric<Client>();
            // Wywołanie funkcji pobrania danych do tabeli
            GetDataFromTable();
        }

        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        /// <param name="ticket"></param>
        public Result(Ticket ticket)
        {
            InitializeComponent();
            _order = new CinemaGeneric<OrderTicket>();
            _client = new CinemaGeneric<Client>();
            GetDataFromTable();
            // Przypisanie okna 
            this.ticket = ticket;
            MessageBox.Show("Zamówienie przyjęte");
        }

        /// <summary>
        /// Połączenie tabeli z bazą danych
        /// </summary>
        public void GetDataFromTable()
        {

            dataGridViewOrder.DataSource = _order.GetAll();
            dataGridViewOrder.Columns["Client"].Visible = false;
            dataGridViewOrder.Columns["Film"].Visible = false;
            dataGridViewOrder.Columns["Ticket"].Visible = false;


            dataGridViewClient.DataSource = _client.GetAll();
        }

        /// <summary>
        /// Pokaż aktualne zamówienie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFiltr_Click(object sender, EventArgs e)
        {
            if (buttonDelete.Enabled == true)
            {
                if (buttonFiltr.Text == "Show my order")
                {
                    var clientId = ticket.CountClients();
                    _context = new CinemaContext();

                    List<OrderTicket> orderList = new List<OrderTicket>();
                    // Czy taka nazwa istnieje 
                    var order = _context.OrderTicket.FirstOrDefault(x => x.ClientId == clientId);

                    orderList.Add(order);

                    dataGridViewOrder.DataSource = orderList;
                    buttonFiltr.Text = "Show all";
                }
                else
                {
                    dataGridViewOrder.DataSource = _order.GetAll();
                    buttonFiltr.Text = "Show my order";
                }
            }
            else
                MessageBox.Show("Twoje zamówienie zostało usunięte");

        }

        /// <summary>
        /// Usuń bieżące zamówienie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            buttonFiltr.Text = "Show my order";
            var clientId = ticket.CountClients();
            var deleteOrder = _context.OrderTicket.FirstOrDefault(x => x.ClientId == clientId);

            _order.DeleteById(deleteOrder.OrderTIcketId);
            _order.Save();
            dataGridViewOrder.DataSource = _order.GetAll();
            buttonDelete.Enabled = false;

        }

        /// <summary>
        /// Poptwierdzenie/Wylogowanie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Czy chcesz się wylogować?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Jeśli zaznaczymy tak wyloguj
            if (rezultat == DialogResult.Yes)
            {
                this.Close();
                ticket.place.film.login.Visible = true;
            }
            else
                return;
        }

        /// <summary>
        /// Otworzenie okna informacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxInfo_Click(object sender, EventArgs e)
        {
            Account account = new Account(this);
            account.Show();
            this.Visible = false;
        }

        /// <summary>
        /// Pokaż aktualne dane klienta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFiltrClient_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Imię: " + ticket.name + " Nazwiko: " + ticket.surname);

            if (buttonFiltrClient.Text == "Show my data")
            {
                var clientId = ticket.CountClients();
                _context = new CinemaContext();

                List<Client> clientList = new List<Client>();
                // Czy taka nazwa istnieje 
                var client = _context.Client.FirstOrDefault(x => x.ClientId == clientId);

                clientList.Add(client);

                dataGridViewClient.DataSource = clientList;
                buttonFiltrClient.Text = "Show all";
            }
            else
            {
                dataGridViewClient.DataSource = _client.GetAll();
                buttonFiltrClient.Text = "Show my data";
            }
        }

        /// <summary>
        /// Zmiana Imienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeName_Click(object sender, EventArgs e)
        {
            textBoxName.Visible = true;
            buttonConfirmName.Visible = true;
            textBoxSurname.Visible = false;
            buttonConfirmSurname.Visible = false;
        }

        /// <summary>
        /// Zmiana Nazwiska
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeSurname_Click(object sender, EventArgs e)
        {
            textBoxSurname.Visible = true;
            buttonConfirmSurname.Visible = true;
            textBoxName.Visible = false;
            buttonConfirmName.Visible = false;
        }

        /// <summary>
        /// Potwierdz nowe imię
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConfirmName_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
                MessageBox.Show("Brak zmian");
            else
            {
                textBoxName.Visible = false;
                buttonConfirmName.Visible = false;

                

                int userId = ticket.CountClients();

                Client editClient = _client.GetById(userId);
                editClient.Name = textBoxName.Text;

                _client.Update(editClient);
                // Zapis
                _client.Save();

                buttonFiltrClient.Text = "Show my data";
                dataGridViewClient.DataSource = _client.GetAll();
                MessageBox.Show("Ustawiono nowe imię");
                ticket.name = textBoxName.Text;
                
            }

        }

        /// <summary>
        /// Potwierdz nowe nazwisko
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConfirmSurname_Click(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "")
                MessageBox.Show("Brak zmian");
            else
            {
                textBoxSurname.Visible = false;
                buttonConfirmSurname.Visible = false;

                int userId = ticket.CountClients();

                Client editClient = _client.GetById(userId);
                editClient.Surname = textBoxSurname.Text;

                _client.Update(editClient);
                // Zapis
                _client.Save();

                buttonFiltrClient.Text = "Show my data";
                dataGridViewClient.DataSource = _client.GetAll();
                MessageBox.Show("Ustawiono nowe nazwisko");
                ticket.surname = textBoxSurname.Text;
            }
        }
    }
}
