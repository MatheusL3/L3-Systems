using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5.Pages
{
	class BasePage : ContentPage
	{
		public BasePage()
		{
			Content = new StackLayout
			{
				Children = {
						new Label { Text = "Hello Contentpage" }
				}
			};
		}
	}
}
