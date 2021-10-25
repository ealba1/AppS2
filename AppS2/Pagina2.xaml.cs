using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            //Abrir pantalla dos

            if ((usuario == "estudiante2021") && (clave == "uisrael2021"))
            {
                await Navigation.PushAsync(new MainPage(usuario, clave));

            }
            else
            {
                lblMensaje.Text = "El usuario o password son incorrectos";
            }

        
    }
    }
}