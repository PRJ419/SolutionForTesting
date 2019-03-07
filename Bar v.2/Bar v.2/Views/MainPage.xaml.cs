using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarInfo.Models;
using BarInfo.ViewModels;
using BarInfo.Views;
using Xamarin.Forms;

namespace Bar_v._2
{
    public partial class MainPage : ContentPage
    {
        private readonly ItemsViewModel _viewModel;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSelectedItem(object sender, SelectedItemChangedEventArgs args)
        {
            if (!(args.SelectedItem is Item item))
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            ItemsListView.SelectedItem = null;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (_viewModel.Items.Count == 0)
            {
                _viewModel.LoadItemsCommand.Execute(null);
            }
        }
    }
}
