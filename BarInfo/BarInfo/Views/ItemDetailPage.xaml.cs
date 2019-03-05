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
	public partial class ItemDetailPage : ContentPage
    {
        private ItemDetailViewModel _viewModel;
        public ItemDetailPage(ItemDetailViewModel viewModel)
		{
			InitializeComponent ();

            BindingContext = _viewModel = viewModel;
        }
	}
}