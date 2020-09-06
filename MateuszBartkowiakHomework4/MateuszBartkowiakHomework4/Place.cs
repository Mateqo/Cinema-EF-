using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszBartkowiakHomework4
{
    public partial class Place : Form
    {
        // Deklaracja zmiennej okna film, by móc się odwoływać
        public FilmSelect film;
        // Deklaracja zmiennej wyboru rzędu
        public string row = "-";
        // Deklaracja zmiennej wyboru miejsca
        public string place = "-";

        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public Place()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        /// <param name="film"></param>
        public Place(FilmSelect film)
        {
            InitializeComponent();
            // Przypisujemy okno film
            this.film = film;
        }

        /// <summary>
        /// Funkcja wyboru miejsca
        /// </summary>
        /// <param name="row"></param>
        /// <param name="place"></param>
        public void SelectPlace(string row,string place)
        {
            // Zmienna która przechowuje powiadomienie, możliwe odpowiedzi yes/no
            DialogResult rezultat = MessageBox.Show("Czy na pewno chcesz wybrać to miejsce?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Jeśli zaznaczymy yes przypisz miejsce
            if (rezultat == DialogResult.Yes)
            {
                ChangeColorSelect(row,place);
                if (row=="A")
                {
                    labelRow.Text = "A";
                    if (place == "1")
                        labelPlace.Text = "1";
                    if (place == "2")
                        labelPlace.Text = "2";
                    if (place == "3")
                        labelPlace.Text = "3";
                    if (place == "4")
                        labelPlace.Text = "4";
                    if (place == "5")
                        labelPlace.Text = "5";
                    if (place == "6")
                        labelPlace.Text = "6";
                    if (place == "7")
                        labelPlace.Text = "7";
                    if (place == "8")
                        labelPlace.Text = "8";
                    if (place == "9")
                        labelPlace.Text = "9";
                }
                if (row == "B")
                {
                    labelRow.Text = "B";
                    if (place == "1")
                        labelPlace.Text = "1";
                    if (place == "2")
                        labelPlace.Text = "2";
                    if (place == "3")
                        labelPlace.Text = "3";
                    if (place == "4")
                        labelPlace.Text = "4";
                    if (place == "5")
                        labelPlace.Text = "5";
                    if (place == "6")
                        labelPlace.Text = "6";
                    if (place == "7")
                        labelPlace.Text = "7";
                    if (place == "8")
                        labelPlace.Text = "8";
                    if (place == "9")
                        labelPlace.Text = "9";
                }
                if (row == "C")
                {
                    labelRow.Text = "C";
                    if (place == "1")
                        labelPlace.Text = "1";
                    if (place == "2")
                        labelPlace.Text = "2";
                    if (place == "3")
                        labelPlace.Text = "3";
                    if (place == "4")
                        labelPlace.Text = "4";
                    if (place == "5")
                        labelPlace.Text = "5";
                    if (place == "6")
                        labelPlace.Text = "6";
                    if (place == "7")
                        labelPlace.Text = "7";
                    if (place == "8")
                        labelPlace.Text = "8";
                    if (place == "9")
                        labelPlace.Text = "9";
                }
                if (row == "D")
                {
                    labelRow.Text = "D";
                    if (place == "1")
                        labelPlace.Text = "1";
                    if (place == "2")
                        labelPlace.Text = "2";
                    if (place == "3")
                        labelPlace.Text = "3";
                    if (place == "4")
                        labelPlace.Text = "4";
                    if (place == "5")
                        labelPlace.Text = "5";
                    if (place == "6")
                        labelPlace.Text = "6";
                    if (place == "7")
                        labelPlace.Text = "7";
                    if (place == "8")
                        labelPlace.Text = "8";
                    if (place == "9")
                        labelPlace.Text = "9";
                }


            }
            // Jeśli no 
            else
                return;
        }
        
        /// <summary>
        /// Zmiana koloru w zależności od wyboru 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="place"></param>
        public void ChangeColorSelect(string row, string place)
        {
            // Wyłap wszystkie kontrolki i jeśli to przycisk to zmien kolor
            foreach (Control x in this.Controls)
                if (x is Button)
                    x.BackColor = Color.Gray;
            // Wyłap wszystkie kontrolki o takiej nazwie i jeśli to przycisk to zmien kolor
            foreach (Control x in this.Controls)
                if (x is Button && x.Name == "buttonPlace" + row + place)
                    x.BackColor = Color.Blue;
        }

        #region Najechanie na miejsce (zaznacz na zielono)

        /// <summary>
        /// Zmiana koloru przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlaceA1_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceA1.BackColor = Color.YellowGreen;
        }   

        private void buttonPlaceA2_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceA2.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceA3_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceA3.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceA4_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceA4.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceA5_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceA5.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceA6_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceA6.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceA7_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceA7.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceA8_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceA8.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceA9_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceA9.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceB1_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceB1.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceB2_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceB2.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceB3_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceB3.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceB4_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceB4.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceB5_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceB5.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceB6_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceB6.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceB7_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceB7.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceB8_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceB8.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceB9_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceB9.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceC1_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceC1.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceC2_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceC2.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceC3_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceC3.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceC4_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceC4.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceC5_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceC5.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceC6_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceC6.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceC7_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceC7.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceC8_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceC8.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceC9_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceC9.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceD1_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceD1.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceD2_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceD2.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceD3_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceD3.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceD4_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceD4.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceD5_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceD5.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceD6_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceD6.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceD7_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceD7.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceD8_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceD8.BackColor = Color.YellowGreen;
        }

        private void buttonPlaceD9_MouseEnter(object sender, EventArgs e)
        {
            buttonPlaceD9.BackColor = Color.YellowGreen;
        }

        #endregion Najechanie na miejsce (zaznacz na zielono)

        #region Opuszczenie przycisku (odznacz)

        /// <summary>
        /// Zmiana koloru przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlaceA1_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceA1.BackColor = Color.Gray;
        }

        private void buttonPlaceA2_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceA2.BackColor = Color.Gray;
        }

        private void buttonPlaceA3_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceA3.BackColor = Color.Gray;
        }

        private void buttonPlaceA4_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceA4.BackColor = Color.Gray;
        }

        private void buttonPlaceA5_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceA5.BackColor = Color.Gray;
        }

        private void buttonPlaceA6_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceA6.BackColor = Color.Gray;
        }

        private void buttonPlaceA7_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceA7.BackColor = Color.Gray;
        }

        private void buttonPlaceA8_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceA8.BackColor = Color.Gray;
        }

        private void buttonPlaceA9_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceA9.BackColor = Color.Gray;
        }

        private void buttonPlaceB1_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceB1.BackColor = Color.Gray;
        }

        private void buttonPlaceB2_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceB2.BackColor = Color.Gray;
        }

        private void buttonPlaceB3_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceB3.BackColor = Color.Gray;
        }

        private void buttonPlaceB4_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceB4.BackColor = Color.Gray;
        }

        private void buttonPlaceB5_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceB5.BackColor = Color.Gray;
        }

        private void buttonPlaceB6_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceB6.BackColor = Color.Gray;
        }

        private void buttonPlaceB7_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceB7.BackColor = Color.Gray;
        }

        private void buttonPlaceB8_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceB8.BackColor = Color.Gray;
        }

        private void buttonPlaceB9_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceB9.BackColor = Color.Gray;
        }

        private void buttonPlaceC1_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceC1.BackColor = Color.Gray;
        }

        private void buttonPlaceC2_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceC2.BackColor = Color.Gray;
        }

        private void buttonPlaceC3_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceC3.BackColor = Color.Gray;
        }

        private void buttonPlaceC4_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceC4.BackColor = Color.Gray;
        }

        private void buttonPlaceC5_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceC5.BackColor = Color.Gray;
        }

        private void buttonPlaceC6_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceC6.BackColor = Color.Gray;
        }

        private void buttonPlaceC7_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceC7.BackColor = Color.Gray;
        }

        private void buttonPlaceC8_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceC8.BackColor = Color.Gray;
        }

        private void buttonPlaceC9_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceC9.BackColor = Color.Gray;
        }

        private void buttonPlaceD1_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceD1.BackColor = Color.Gray;
        }

        private void buttonPlaceD2_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceD2.BackColor = Color.Gray;
        }

        private void buttonPlaceD3_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceD3.BackColor = Color.Gray;
        }

        private void buttonPlaceD4_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceD4.BackColor = Color.Gray;
        }

        private void buttonPlaceD5_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceD5.BackColor = Color.Gray;
        }

        private void buttonPlaceD6_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceD6.BackColor = Color.Gray;
        }

        private void buttonPlaceD7_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceD7.BackColor = Color.Gray;
        }

        private void buttonPlaceD8_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceD8.BackColor = Color.Gray;
        }

        private void buttonPlaceD9_MouseLeave(object sender, EventArgs e)
        {
            buttonPlaceD9.BackColor = Color.Gray;
        }

        #endregion Opuszczenie przycisku (odznacz)

        #region Wybór miejsca

        /// <summary>
        /// Wybór miejsca, wywołanie funkcji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlaceA1_Click(object sender, EventArgs e)
        {
            SelectPlace("A", "1");
        }

        private void buttonPlaceA2_Click(object sender, EventArgs e)
        {
            SelectPlace("A", "2");
        }

        private void buttonPlaceA3_Click(object sender, EventArgs e)
        {
            SelectPlace("A", "3");
        }

        private void buttonPlaceA4_Click(object sender, EventArgs e)
        {
            SelectPlace("A", "4");
        }

        private void buttonPlaceA5_Click(object sender, EventArgs e)
        {
            SelectPlace("A", "5");
        }

        private void buttonPlaceA6_Click(object sender, EventArgs e)
        {
            SelectPlace("A", "6");
        }

        private void buttonPlaceA7_Click(object sender, EventArgs e)
        {
            SelectPlace("A", "7");
        }

        private void buttonPlaceA8_Click(object sender, EventArgs e)
        {
            SelectPlace("A", "8");
        }

        private void buttonPlaceA9_Click(object sender, EventArgs e)
        {
            SelectPlace("A", "9");
        }

        private void buttonPlaceB1_Click(object sender, EventArgs e)
        {
            SelectPlace("B", "1");
        }

        private void buttonPlaceB2_Click(object sender, EventArgs e)
        {
            SelectPlace("B", "2");
        }

        private void buttonPlaceB3_Click(object sender, EventArgs e)
        {
            SelectPlace("B", "3");
        }

        private void buttonPlaceB4_Click(object sender, EventArgs e)
        {
            SelectPlace("B", "4");
        }

        private void buttonPlaceB5_Click(object sender, EventArgs e)
        {
            SelectPlace("B", "5");
        }

        private void buttonPlaceB6_Click(object sender, EventArgs e)
        {
            SelectPlace("B", "6");
        }

        private void buttonPlaceB7_Click(object sender, EventArgs e)
        {
            SelectPlace("B", "7");
        }

        private void buttonPlaceB8_Click(object sender, EventArgs e)
        {
            SelectPlace("B", "8");
        }

        private void buttonPlaceB9_Click(object sender, EventArgs e)
        {
            SelectPlace("B", "9");
        }

        private void buttonPlaceC1_Click(object sender, EventArgs e)
        {
            SelectPlace("C", "1");
        }

        private void buttonPlaceC2_Click(object sender, EventArgs e)
        {
            SelectPlace("C", "2");
        }

        private void buttonPlaceC3_Click(object sender, EventArgs e)
        {
            SelectPlace("C", "3");
        }

        private void buttonPlaceC4_Click(object sender, EventArgs e)
        {
            SelectPlace("C", "4");
        }

        private void buttonPlaceC5_Click(object sender, EventArgs e)
        {
            SelectPlace("C", "5");
        }

        private void buttonPlaceC6_Click(object sender, EventArgs e)
        {
            SelectPlace("C", "6");
        }

        private void buttonPlaceC7_Click(object sender, EventArgs e)
        {
            SelectPlace("C", "7");
        }

        private void buttonPlaceC8_Click(object sender, EventArgs e)
        {
            SelectPlace("C", "8");
        }

        private void buttonPlaceC9_Click(object sender, EventArgs e)
        {
            SelectPlace("C", "9");
        }

        private void buttonPlaceD1_Click(object sender, EventArgs e)
        {
            SelectPlace("D", "1");
        }

        private void buttonPlaceD2_Click(object sender, EventArgs e)
        {
            SelectPlace("D", "2");
        }

        private void buttonPlaceD3_Click(object sender, EventArgs e)
        {
            SelectPlace("D", "3");
        }

        private void buttonPlaceD4_Click(object sender, EventArgs e)
        {
            SelectPlace("D", "4");
        }

        private void buttonPlaceD5_Click(object sender, EventArgs e)
        {
            SelectPlace("D", "5");
        }

        private void buttonPlaceD6_Click(object sender, EventArgs e)
        {
            SelectPlace("D", "6");
        }

        private void buttonPlaceD7_Click(object sender, EventArgs e)
        {
            SelectPlace("D", "7");
        }

        private void buttonPlaceD8_Click(object sender, EventArgs e)
        {
            SelectPlace("D", "8");
        }

        private void buttonPlaceD9_Click(object sender, EventArgs e)
        {
            SelectPlace("D", "9");
        }

        #endregion Wybór miejsca

        /// <summary>
        /// Wyloguj się
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Jeśli naciśniemy Yes
            if (rezultat == DialogResult.Yes)
            {
                this.Close();
                film.login.Visible = true;
            }
            else
                return;
        }

        /// <summary>
        /// Poprzednie okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
            film.Visible = true;
        }

        /// <summary>
        /// Następne okno 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxNext_Click(object sender, EventArgs e)
        {
            // Spradz czy wszystko zaznaczono
            if(labelRow.Text=="-" || labelPlace.Text=="-")
            {
                MessageBox.Show("Nie wybrano miejsca");
            }
            else
            {
                Ticket ticket = new Ticket(this);
                this.Visible = false;
                ticket.Show();
            }
            // Przypisz wybrany rząd i miejsce
            row = labelRow.Text;
            place = labelPlace.Text;

        }

        /// <summary>
        /// Uruchomienie okna informacji
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
