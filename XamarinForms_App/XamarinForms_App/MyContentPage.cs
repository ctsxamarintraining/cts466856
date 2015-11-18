using System;

using Xamarin.Forms;

namespace XamarinForms_App
{
	public class MyContentPage : ContentPage
	{
		public MyContentPage ()
		{
//			Content = new StackLayout { 
//				Children = {
//					new Label { Text = "Hello ContentPage" }
//				}
//			};

			Content = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					//CreateLabel ("Color.R", "R = {0:F2}"),
					new Label { Text = "The Page",TextColor = Color.White }
				}
			};
		}
	}
}


