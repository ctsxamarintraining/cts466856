using System;
using Xamarin.Forms;

namespace XamarinFormApp1
{
	public class MenuContent
	{
		
		public MenuContent(string name,Color color)
			{
				this.Name = name;
				this.Color = color;
			}

			public string Name { private set; get; }

			public Color Color { private set; get; }

			public override string ToString()
			{
				return Name;
			}

	}
}

