﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new iseseisev();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
