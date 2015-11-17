using System;

using Xamarin.Forms;

namespace XamarinFormApp1
{
	public class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


