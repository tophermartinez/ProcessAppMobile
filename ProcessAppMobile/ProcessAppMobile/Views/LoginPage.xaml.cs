using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.ServiceModel;
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

        ServiceReference2.LoginRequestBody ws = new ServiceReference2.LoginRequestBody();

        HttpClient cliente = new HttpClient();
        HttpClient cliente2 = new HttpClient();

        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
            btnLog.Clicked += btnLog_Click;

        }


        public async void btnLog_Click(Object sender, EventArgs args)
        {

            try
            {
                var servicio = DependencyService.Get<IValidar>();
                string resultado = servicio.EsValidoLogin(usu.Text, pass.Text);


                if (string.IsNullOrEmpty(resultado) || resultado == "nulll")
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


        // ServiceReference2.ServiceProcessSoap ws = new ServiceReference2.ServiceProcessSoap();

        //private async void btnLog_Click(Object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(usu.Text))
        //    {
        //        await DisplayAlert("Error", "Debe ingresar el Usuario", "Aceptar");
        //        usu.Focus();
        //        return;
        //    }

        //    if (string.IsNullOrEmpty(pass.Text))
        //    {
        //        await DisplayAlert("Error", "Debe ingresar la contraseña", "Aceptar");
        //        pass.Focus();
        //        return;
        //    }

        //    try
        //    {


        //        //var binding = new BasicHttpBinding()
        //        //{
        //        //    MaxBufferSize = 2147483647,
        //        //    MaxReceivedMessageSize = 2147483647
        //        //};
        //        //IsBusy = true;
        //        //ServiceReference1.ServiceProcessSoapClient servicio = new ServiceReference1.ServiceProcessSoapClient(
        //        //  binding,
        //        //  new EndpointAddress("http://miservidor.com/webservice/servicio.asmx")););




        //        // ws.LoginAsync.url
        //        // ServiceReference2.ServiceProcessSoap ws = new ServiceReference2.ServiceProcessSoap();
        //        //ws.pass
        //        cliente.BaseAddress = new Uri("http://localhost/LocalWs/ServiceProcess.asmx");


        //        ActivityIndicator waitActivityIndicator = new ActivityIndicator();
        //        waitActivityIndicator.IsRunning = true;

        //        btnLog.IsEnabled = false;
        //        cliente2 = cliente;
        //        String url = string.Format("?op=Login /{0}/{1}", usu.Text, pass.Text);
        //        var resp = await cliente2.GetAsync(url);
        //        var result = resp.Content.ReadAsStringAsync().Result;
        //        btnLog.IsEnabled = true;
        //        waitActivityIndicator.IsRunning = false;

        //        if (string.IsNullOrEmpty(result) || result == "nulll")
        //        {
        //            await DisplayAlert("Error", "Usuario o Contraseña no Validos", "Aceptar");
        //            pass.Text = string.Empty;
        //            pass.Focus();
        //            return;

        //        }
        //        else
        //        {
        //            await Navigation.PushAsync(new ItemDetailPage());
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        new Exception("Usuario o Contraseña incorrecta " + ex.Message); 
        //    }


        //    }


    }
}