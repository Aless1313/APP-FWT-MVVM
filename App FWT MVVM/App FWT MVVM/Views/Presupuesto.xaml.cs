using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Syncfusion.SfNumericUpDown;
using Syncfusion.SfNumericUpDown.XForms;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_FWT_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Presupuesto : ContentPage
    {
        int a=0; //Variable para bloquear numericUpDown   
        public Presupuesto()
        {
            InitializeComponent(); 
            var date1 = DateTime.Now.ToString ("MMMM");
            MesShow.Text = date1.ToUpper();
        }

        private void ValorMes_Clicked(object sender, EventArgs e)
        {
                numericUpDown.IsEnabled = false;
                MesAsignado.IsVisible = true;
                Editar.IsVisible = true;
                Borde.IsVisible = true;
        }

        private void Editar_Clicked(object sender, EventArgs e)
        {
            numericUpDown.IsEnabled = true;
            MesAsignado.IsVisible = false;
            Editar.IsVisible = false;
            Borde.IsVisible = false;
        }
       
    }
}