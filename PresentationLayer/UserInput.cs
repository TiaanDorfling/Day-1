using System;

using Day_1.BussinessLogic;

namespace Day_1.PresentationLayer
{
	internal class UserInput
	{
		public UserInput() { }

		enum menu
		{
			Search,
			Add,
			Delete,
			Exit
		}

		enum actions
		{
			DisplayText,
			AddText,
			ClearText
		}

		public void Display()
		{
			foreach (var var in Enum.GetValues(typeof(menu)))
			{
				Console.WriteLine($"{(int)var + 1}. {var.ToString()}");
			}

			Navigation bl = new Navigation();
			bl.navigation();
		}

		public void DisplayActions()
		{
			foreach (var var in Enum.GetValues(typeof(actions)))
			{
				Console.WriteLine($"{(int)var + 1}. {var.ToString()}");
			}
		}
	}
}
