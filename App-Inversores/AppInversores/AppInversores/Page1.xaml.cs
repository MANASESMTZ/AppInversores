using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppInversores
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string t,string i1,string i2,string i3)
        {
            InitializeComponent();

            Total.Text = t;
            INV1.Text = i1+"%";
            INV2.Text = i2+"%";
            INV3.Text = i3+"%";
        }
    }
}