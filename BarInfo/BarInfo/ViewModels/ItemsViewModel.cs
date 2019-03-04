using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using BarInfo.Models;
using BarInfo.Views;

namespace BarInfo.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Bar-O-Meter";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await OnExecuteLoadItemsCommand());
        }

        private async Task OnExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;
            IsBusy = true;
            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsyncTask(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Debug.WriteLine(e);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
