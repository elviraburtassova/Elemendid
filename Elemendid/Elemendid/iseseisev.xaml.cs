using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class iseseisev : ContentPage
	{
		DatePicker dPicker;
		Image image;
		Entry ent;

		public iseseisev()
		{
			Grid grd = new Grid();
			//--------------------------------------------------------------
			//Колонны
			ColumnDefinition colDef1 = new ColumnDefinition();
			ColumnDefinition colDef2 = new ColumnDefinition();
			grd.ColumnDefinitions.Add(colDef1);
			grd.ColumnDefinitions.Add(colDef2);
			//Ряды
			RowDefinition rowDef1 = new RowDefinition();
			RowDefinition rowDef2 = new RowDefinition();
			grd.RowDefinitions.Add(rowDef1);
			grd.RowDefinitions.Add(rowDef2);

			//-----------------------------------------
			// DatePicker
			dPicker = new DatePicker
			{
				BackgroundColor = Color.LightPink,
				Format = "D",
			};
			dPicker.DateSelected += DPicker_DateSelected;
			grd.Children.Add(dPicker, 0, 0);

			//----------------------------------------------------------------
			// Entry
			ent = new Entry
			{ 
				BackgroundColor= Color.LightBlue,
				Text="Ваш знак зодиака",
			};
			grd.Children.Add(ent, 0, 1);
			Grid.SetColumnSpan(ent, 2);

			//-------------------------------------------------------------------
			// image
			image = new Image();
			image.Source = "ov.jpg";
			image.Source = "tel.jpg";
			image.Source = "bliz.jpg";
			image.Source = "rak.jpg";
			image.Source = "lev.jpg";
			image.Source = "deva.jpg";
			image.Source = "vesi.jpg";
			image.Source = "skorp.jpg";
			image.Source = "strel.jpg";
			image.Source = "koz.jpg";
			image.Source = "vodol.jpg";
			image.Source = "robi.jpg";
			grd.Children.Add(image, 1, 0);



			Content = grd;
		}

		private void DPicker_DateSelected(object sender, DateChangedEventArgs e)
		{
			ent.Text = "Ваш знак зодиака:\n" + e.NewDate.ToString("d");
		}
	}
}