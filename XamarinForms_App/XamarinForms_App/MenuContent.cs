using System;

using Xamarin.Forms;

namespace XamarinForms_App
{
	public class MenuContent
	{
		public MenuContent (Type PageType,string inTitle)
		{
			ThisPageType = PageType;
			ThisPageTitle = inTitle;
		}

		public Type ThisPageType { private set; get; }
		public string ThisPageTitle { private set; get; }
	}
}


