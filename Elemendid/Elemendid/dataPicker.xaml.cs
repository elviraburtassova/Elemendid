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
	public partial class dataPicker : ContentPage
	{
		Picker pick;
		Editor editor;
		DatePicker dPicker;
		Entry ent;
		TimePicker tPicker;
		Frame frame;
		public dataPicker()
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
			RowDefinition rowDef3 = new RowDefinition();
			grd.RowDefinitions.Add(rowDef1);
			grd.RowDefinitions.Add(rowDef2);
			grd.RowDefinitions.Add(rowDef3);

			//----------------------------------------------------------------
			//Picker
			pick = new Picker
			{
				Title = "Picker"
			};

			pick.Items.Add("C#");
			pick.Items.Add("Python");
			pick.Items.Add("C++");
			pick.Items.Add("BisualBasic");
			pick.Items.Add("Java");
            grd.Children.Add(pick, 0,0);
			pick.SelectedIndexChanged += Pick_SelectedIndexChanged;

			//---------------------------------------------------------------
			// Editor
			editor = new Editor { Placeholder = "Выберите язык программирования в списке" };
			grd.Children.Add(editor, 1, 0);

			//-----------------------------------------
			// DatePicker
			dPicker = new DatePicker
			{
				Format = "D",
				MinimumDate = DateTime.Now.AddDays(-10),
			    MaximumDate = DateTime.Now.AddDays(10)
			};
			dPicker.DateSelected += DPicker_DateSelected;
			grd.Children.Add(dPicker, 1, 1);

			//----------------------------------------------------------------
			// Entry
			ent = new Entry { Text = "Выберите число" };
			grd.Children.Add(ent, 0, 1);

			//-----------------------------------------------------
			// TimePicker
			tPicker = new TimePicker()
			{
				// Time = new TimeSpan(18,0,0)
				Time = new TimeSpan(DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second)
			};
			grd.Children.Add(tPicker,1,1);

			//-----------------------------------------------------------
			// Frame
			frame = new Frame()
			{
				BorderColor=Color.Pink,
				HasShadow = true,
				BackgroundColor=Color.LightBlue,
				Content = new Label { Text="Приветик)"}
			};
			grd.Children.Add(frame, 0, 2);
			Grid.SetColumnSpan(frame, 2);
		
		 

			Content = grd;
		}

		private void DPicker_DateSelected(object sender, DateChangedEventArgs e)
		{
			ent.Text = "Ваше число:\n" + e.NewDate.ToString("G");
		}

		private void Pick_SelectedIndexChanged(object sender, EventArgs e)
		{
			editor.Text = "Было выбранно: " + pick.Items[pick.SelectedIndex];
		}
	}
}