using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormApp1
{
	public class NewContentPage : ContentPage
	{
		public NewContentPage (Color BackColor,string TheTitle)
		{
//			Content = new StackLayout { 
//				Children = {
//					new Label { Text = "Hello ContentPage" }
//				}
//			};

			this.Title = TheTitle;
			this.BackgroundColor = BackColor;

			Content = new StackLayout {
				BackgroundColor = BackColor,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					//CreateLabel ("Color.R", "R = {0:F2}"),
					new Label { Text = "The Page",TextColor = Color.White }
				}
			};
		}

		public Label CreateLabel(string source, string fmt)
		{
			Label label = new Label {
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				XAlign = TextAlignment.Center
			};
			label.SetBinding(Label.TextProperty,
				new Binding(source, BindingMode.OneWay, null, null, fmt));

			return label;
		}
	}
}


