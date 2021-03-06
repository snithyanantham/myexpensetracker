﻿using MyFamilyManager.Mobile.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyFamilyManager.Mobile.Services
{
    public class MyFamilyManageDataStore
    {
        HttpClient httpClient;

        public MyFamilyManageDataStore()
        {
            httpClient = new HttpClient();
        }
        public async Task<CategoryList> GetCategories()
        {
            var response = await httpClient.GetAsync("http://10.0.2.2:5000/category").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var categories = JsonConvert.DeserializeObject<CategoryList>(content);
            return categories;
        }

        public async Task<SubCategoryList> GetSubCategories(string categoryId)
        {
            var response = await httpClient.GetAsync("http://10.0.2.2:5000/category/{" + categoryId + "}/subcategories").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var subcategories = JsonConvert.DeserializeObject<SubCategoryList>(content);
            return subcategories;
        }
    }
}
