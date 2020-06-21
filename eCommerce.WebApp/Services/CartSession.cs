using eCommerce.ViewModels.Catalog.Carts;
using eCommerce.ViewModels.System.Users;
using Microsoft.AspNetCore.Http;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myeshop.AdminApp.Services
{
    public static class CartSession
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static List<CartItemViewModel> GetObjectFromJson<List>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(List<CartItemViewModel>) : JsonConvert.DeserializeObject<List<CartItemViewModel>>(value);
        }

    }
}