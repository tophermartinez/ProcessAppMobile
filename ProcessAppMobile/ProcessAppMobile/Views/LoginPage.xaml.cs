using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ProcessAppMobile.Models;
using ProcessAppMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProcessAppMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
            btnLog.Clicked += btnLog_Click;

        }

        private async void btnLog_Click(Object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usu.Text))
            {
                await DisplayAlert("Error", "Debe ingresar el Usuario", "Aceptar");
                usu.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass.Text))
            {
                await DisplayAlert("Error", "Debe ingresar la contraseña", "Aceptar");
                pass.Focus();
                return;
            }

            try
            {
                ActivityIndicator waitActivityIndicator = new ActivityIndicator();
                waitActivityIndicator.IsRunning = true;
                btnLog.IsEnabled = false;
                HttpClient cliente = new HttpClient();
                cliente.BaseAddress = new Uri("https://172.18.53.33:44354/ServiceProcess.asmx");
                String url = string.Format("/Login /{0}/{1}", usu.Text, pass.Text);
                var resp = await cliente.GetAsync(url);
                var result = resp.Content.ReadAsStringAsync().Result;
                btnLog.IsEnabled = true;
                waitActivityIndicator.IsRunning = false;

                if (string.IsNullOrEmpty(result) || result == "nulll")
                {
                    await DisplayAlert("Error", "Usuario o Contraseña no Validos", "Aceptar");
                    pass.Text = string.Empty;
                    pass.Focus();
                    return;

                }
                else
                {
                    await Navigation.PushAsync(new ItemDetailPage());
                }


            }
            catch (Exception ex)
            {
                new Exception("Usuario o Contraseña incorrecta " + ex.Message); 
            }

                
            }

        
    }
}