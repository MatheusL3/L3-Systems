using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App5.Pages
{
	public class IndexPage : ContentPage
	{
		public IndexPage()
		{
			var telefone = new Button()
			{
				Text = "(62) 98332-1754"
			};
			telefone.Clicked += (sender, e) => Device.OpenUri(new Uri("tel://62983321754"));

			Content = new ContentView()
			{
				Content = new StackLayout
				{
					Children = {
						new Image {
							Aspect = Aspect.AspectFit,
							Source = Device.OnPlatform(
								iOS: ImageSource.FromFile("logo.jpeg"),
								Android: ImageSource.FromFile("logo.jpeg"),
								WinPhone: null
								)
						},
						telefone
						
					}
				}

			};
		}
	}
}