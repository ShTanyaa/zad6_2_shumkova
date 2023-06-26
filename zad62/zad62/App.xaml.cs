﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad62
{
    public partial class App :Application
    {
        public App ()
        {
            InitializeComponent();

            var mainPage = new MainPage();
            MainPage = new NavigationPage(mainPage);
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
