using System;

using Xamarin.Forms;

namespace XamarinForms_App
{
	public class MyCustomerPage : ContentPage
	{
		public MyCustomerPage ()
		{
			BackgroundColor = Color.Olive;
			Title = "Details Page";
			Content = new ScrollView {
				Content = new StackLayout { 
					VerticalOptions = LayoutOptions.Center,
					Padding = new Thickness (20),
					Children = {
						new RelativeLayout {
							// customer name
						},
						new RelativeLayout {
							// date of birth
						},
						new RelativeLayout {
							// gender
						},
						new RelativeLayout {
							// description
						},
						new RelativeLayout {
							// country
						},
						//savebutton,
					}
				}
			};
		}
	}
}


