using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private async void AddItem_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Item added", "Well done", "ok");
        }

        private async void ItemsListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await DisplayAlert("Item selected", "Well done", "ok");
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