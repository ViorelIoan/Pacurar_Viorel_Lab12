﻿using Pacurar_Viorel_Lab12.ViewModels;
using Pacurar_Viorel_Lab12.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Pacurar_Viorel_Lab12
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
