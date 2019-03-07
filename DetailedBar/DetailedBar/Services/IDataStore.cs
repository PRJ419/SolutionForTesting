using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DetailedBar.Models;

namespace DetailedBar.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsyncTask(T item);
        Task<Item> GetItemsAsyncTask(string id);

        Task<IEnumerable<Item>> GetItemsAsyncTask(bool forceRefresh = false);

    }
}
