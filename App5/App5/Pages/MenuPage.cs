using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App5.Pages
{
	public class MenuPage : TabbedPage
	{
		public MenuPage()
		{
			Title = "Menu";

			Children.Add(new IndexPage()
			{
				Title = "Início",
				Icon = "home.jpg"
			});

			Children.Add(new ServicosPage()
			{
				Title = "Servicos",
				Icon = "servicos.jpg"
			});

			Children.Add(new MapaPage()
			{
				Title = "Localização",
				Icon = "map.jpg"
			});


		}
	}
}