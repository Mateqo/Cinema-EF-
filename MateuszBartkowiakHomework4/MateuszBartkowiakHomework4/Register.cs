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
    public partial class Register : Form
    {
        // Zmienna by móc się odwoływać do okna login
        Login login;

        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public Register()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        /// <param name="login"></param>
        public Register(Login login)
        {
            InitializeComponent();
            // Przpisanie okna
            this.login = login;
        }

        /// <summary>
        /// Czyszczenie zawartości label
        /// </summary>
        public void Clear()
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }

        /// <summary>
        /// Rejestracja, sprawdza czy można dodać takiego użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            RegisterAccount register = new RegisterAccount();

            // Sprawdzenie czy nazwa jest zajęta
            if(register.IsFree(textBoxLogin.Text))
            {
                register.AddNewAccount(textBoxLogin.Text, textBoxPassword.Text);

                // Wyczyszczenie texboxów
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";

                MessageBox.Show("Zalogowano");
            }
            else
            {
                MessageBox.Show("Login jest już zajęty!");
            }

        }
        
        /// <summary>
        /// Powrót
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxPrevious_Click(object sender, EventArgs e)
        {
            // Ukryj bieżące okno, pokaż okno login
            this.Visible = false;
            login.Visible = true;
        }
    }
}
