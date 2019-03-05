using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarInfo.Models;
using Xamarin.Forms;

namespace BarInfo.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        private readonly List<Item> _items;

        public MockDataStore()
        {
            _items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Katrines kælder", Description="Lets get it on!", Image = "bar.jpg"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dat-Bar", Description="Meh", Image = "chess.jpg"}
            };

            foreach (var item in mockItems)
            {
                Debug.WriteLine(item);
                _items.Add(item);
            }
        }


        public async Task<bool> AddItemAsyncTask(Item item)
        {
            _items.Add(item);
            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemsAsyncTask(string id)
        {
            return await Task.FromResult(_items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsyncTask(bool forceRefresh = false)
        {
            return await Task.FromResult(_items);
        }
    }
}
