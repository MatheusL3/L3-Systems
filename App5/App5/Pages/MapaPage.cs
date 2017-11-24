using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Maps;

using Xamarin.Forms;

namespace App5.Pages
{
	public class MapaPage : ContentPage
	{
		public MapaPage()
		{


            var Mapa = new Map();

            Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(
                        new Position(-16.673914, -49.210024),
                        Distance.FromMiles(0.5)));


            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-16.673914, -49.210024),
                Label = "L3 Systems",
                Address = "Av. Pedro Alvares Cabral, Res. Monte Fuji",
            };

            Mapa.Pins.Add(pin);

            Content = new StackLayout
			{
				Children = {
                    Mapa
                }
			};
        }
    }
}