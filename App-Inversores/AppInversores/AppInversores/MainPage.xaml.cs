using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppInversores
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            double inversor1 = 0;
            double inversor2 = 0;
            double inversor3 = 0;

            double total = 0;

            double resultado1 = 0;
            double resultado2 = 0;
            double resultado3 = 0;

            inversor1 = Double.Parse(INVERSION1.Text);
            inversor2 = Double.Parse(INVERSION2.Text);
            inversor3 = Double.Parse(INVERSION3.Text);

            total = inversor1 + inversor2 + inversor3;

            resultado1 = (inversor1 / total) * 100;
            resultado2 = (inversor2 / total) * 100;
            resultado3 = (inversor3 / total) * 100;

            await Navigation.PushAsync(new Page1(total.ToString("#.##"),resultado1.ToString("#.##"), resultado2.ToString("#.##"), resultado3.ToString("#.##")));

        }
    }
}
