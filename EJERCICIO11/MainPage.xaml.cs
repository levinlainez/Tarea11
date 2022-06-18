using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EJERCICIO11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnDividir_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtNum1.Text);
            var num2 = Convert.ToDecimal(txtNum2.Text);
            await Navigation.PushAsync(new Views.ResultPage(Convert.ToDecimal(num1 / num2)));
        }

        private async void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtNum1.Text);
            var num2 = Convert.ToDecimal(txtNum2.Text);
            await Navigation.PushAsync(new Views.ResultPage(Convert.ToDecimal(num1 * num2)));

        }

        private async void btnRestar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtNum1.Text);
            var num2 = Convert.ToDecimal(txtNum2.Text);
            await Navigation.PushAsync(new Views.ResultPage(Convert.ToDecimal(num1 - num2)));
        }

        private async void btnSumar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtNum1.Text);
            var num2 = Convert.ToDecimal(txtNum2.Text);
            await Navigation.PushAsync(new Views.ResultPage(Convert.ToDecimal(num1 + num2)));
        }
    }
}
