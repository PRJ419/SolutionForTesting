using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarInfo.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BarInfo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewItemPage : ContentPage
	{
        public Item Item { get; set; }
		public NewItemPage ()
		{
			InitializeComponent ();

            Item = new Item
            {
                Text = "Item name",
                Description = "Described"
            };

            BindingContext = this;
        }
	}
}