﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Modul3_Practice
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new Modul3_Practice.MainPage();
            MainPage = new Modul3_Practice.BindingListString();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
