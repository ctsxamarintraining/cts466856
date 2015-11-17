using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinFormApp1
{
	public class NewCarouselPage : CarouselPage
	{
		public NewCarouselPage ()
		{
			List<ContentPage> pages = new List<ContentPage> (0);
			Color[] colors = { Color.Red, Color.Green, Color.Blue,Color.Gray,Color.Yellow };
			foreach (Color c in colors) {
				pages.Add (new NewContentPage(Color.Accent,"Carousel1"));
				pages.Add (new NewContentPage(Color.Green,"Carousel2"));
				pages.Add (new NewContentPage(Color.Lime,"Carousel3"));
			}
			this.Children.Add (pages[0]);
			this.Children.Add (pages[1]);
			this.Children.Add (pages[2]);
			this.Children.Add (pages[3]);
			this.Children.Add (pages[4]);


		}
	}
}


