using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using App_FWT_MVVM.Views;
using ZXing.Net.Mobile.Forms;

namespace App_FWT_MVVM.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string user;
        public string User
        {
            get { return user; }
            set
            {
                user = value;
                PropertyChanged(this, new PropertyChangedEventArgs("User"));
            }
        }

        private string mail;
        public string Mail
        {
            get { return mail; }
            set
            {
                mail = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Mail"));
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        private string mac;
        public string Mac
        {
            get { return mac; }
            set
            {
                mac = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Mac"));
            }
        }

        public Command ScanCommand
        {
            get
            {
                return new Command(Scan);
            }
        }

        public async void Scan()
        {
            var scannerPage = new ZXingScannerPage();
            scannerPage.Title = "Escanee el codigo de su dispositivo";
            scannerPage.OnScanResult += (result) =>
            {
                scannerPage.IsScanning = true;

                Device.BeginInvokeOnMainThread(async () =>
                {
                    Mac = result.Text;
                    await App.Current.MainPage.Navigation.PopAsync();
                    await App.Current.MainPage.DisplayAlert("Escaneado", result.Text, "OK");
                    
                });
            };
            await App.Current.MainPage.Navigation.PushAsync(scannerPage);
        }

        public Command RegisterCommand
        {
            get
            {
                return new Command(Register);
            }
        }

        public async void Register()
        {
            if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Mail) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Mac))
            {
                await App.Current.MainPage.DisplayAlert("Campos vacios", "Ingrese información", "Ok");
            }
            else
            {
                await RegisterAccount("http://developerfwt.atwebpages.com/php/registro.php?user="+User.ToString()+"&mail="+Mail.ToString()+"&password="+Password.ToString()+"&mac="+Mac.ToString());
            }
        }

        private async Task RegisterAccount(string url)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                await App.Current.MainPage.DisplayAlert("Exito", "Su cuenta se ha creado, ahora inicie sesion", "ok");
                await App.Current.MainPage.Navigation.PopToRootAsync();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Fallo", "Ocurrio un error", "ok");
            }
        }

    }
}
