using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace XamarinForms_App
{
	public partial class FootballPlayerListPage : ContentPage
	{
		public FootballPlayerListPage ()
		{
			this.BindingContext = new FootballPlayerListViewModel();
			InitializeComponent ();
		}
	}
}

