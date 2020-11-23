﻿using System.ComponentModel;
using Xamarin.Forms;
using ProcessAppMobile.ViewModels;

namespace ProcessAppMobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}