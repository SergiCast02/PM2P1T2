using PM2P1T2.Models;
using PM2P1T2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2P1T2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnenviarinfo_Clicked(object sender, EventArgs e)
        {
            try
            {
                var persona = new Persona
                {
                    nombres = nombres.Text,
                    apellidos = apellidos.Text,
                    edad = Int32.Parse(edad.Text),
                    correo = correo.Text
                };
                var secondPage = new Resultados();
                secondPage.BindingContext = persona;
                await Navigation.PushAsync(secondPage);
            }
            catch (Exception error)
            {
                await DisplayAlert("Aviso", "Llene todos los campos", "OK");
            }
        }
    }
}
