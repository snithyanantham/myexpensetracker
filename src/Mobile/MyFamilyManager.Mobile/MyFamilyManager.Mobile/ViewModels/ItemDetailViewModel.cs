﻿using System;
using MyFamilyManager.Mobile.Infrastructure;
using MyFamilyManager.Mobile.Models;

namespace MyFamilyManager.Mobile.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
