using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BarInfo.Models;

namespace BarInfo.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsyncTask(T item);
        Task<Item> GetItemsAsyncTask(string id);

        Task<IEnumerable<Item>> GetItemsAsyncTask(bool forceRefresh = false);

    }
}
