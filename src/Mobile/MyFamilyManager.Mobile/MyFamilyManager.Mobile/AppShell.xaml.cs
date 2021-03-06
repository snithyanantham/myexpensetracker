﻿using MyFamilyManager.Mobile.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyFamilyManager.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("itemdetailpage", typeof(ItemDetailPage));
            Routing.RegisterRoute("itemspage", typeof(ItemsPage));
        }
    }
}
