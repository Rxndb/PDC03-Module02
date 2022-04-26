using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MOD02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnNextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity1());
        }
        private async void OnNextPageII(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity2());
        }
    }
}
