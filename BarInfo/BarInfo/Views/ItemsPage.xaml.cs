using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarInfo.Models;
using BarInfo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BarInfo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemsPage : ContentPage
    {
        private readonly ItemsViewModel _viewModel;
		public ItemsPage ()
		{
			InitializeComponent ();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        private async void OnSelectedItem(object sender, SelectedItemChangedEventArgs args)
        {
            if (!(args.SelectedItem is Item item))
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

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