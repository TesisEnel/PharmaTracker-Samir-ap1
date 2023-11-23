using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Text.Json;
using System.Text;
using PharmaTracker.Shared;

namespace PharmaTracker.Client.Extensions
{
    public static class SessionStorageExtension
    {
        public static async Task SaveStorage<T>(
            this ISessionStorageService sessionStorageService,
            string key, T item
            )where T : class
        {
            var itemJson = JsonSerializer.Serialize(item);
            await sessionStorageService.SetItemAsStringAsync(key, itemJson);
        }
        public static async Task<T?> GetStorage<T>(
        this ISessionStorageService sessionStorageService,
        string key
        ) where T : class
        {
            var itemJson = await sessionStorageService.GetItemAsStringAsync(key);

            if (itemJson != null)
            {
                var item = JsonSerializer.Deserialize<T>(itemJson);
                return item;
            }
            else
                return null;
        }
    } 
}
