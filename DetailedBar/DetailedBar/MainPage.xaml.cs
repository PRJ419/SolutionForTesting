using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DetailedBar.Views;
using Xamarin.Forms;

namespace DetailedBar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Events_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BarsClicked_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemsPage());
        }
    }
}
