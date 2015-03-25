using System;

using Xamarin.Forms;

namespace ActionSheetXamrineForm
{
	public class ActionSheetPage : ContentPage
	{

		public ActionSheetPage ()
		{

			var label = new Label
			{
				Text = "ActionSheetDemo",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand, 
			};
			var btn1 = new Button
			{ 
				Text="ActionSheet Simple ",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand, 
			};
			var btn2 = new Button
			{ 
				Text="ActionSheet Cancel/Delete",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand, 
			};

			btn1.Clicked += async (sender, e) => {
				var action = await DisplayActionSheet ("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");

			};
			btn2.Clicked += async (sender, e) => {
				var action= await DisplayActionSheet ("ActionSheet: Save Photo?","Cancel","Delete","Photo Roll","Email");
			};

			Content = new StackLayout {
				Children = {

					label,btn1,btn2
				}
			};
		}
	}
}


