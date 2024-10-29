using System;
using System.IO;

using Day_1.PresentationLayer;

namespace Day_1.BussinessLogic
{
	internal class Navigation
	{
		public Navigation() { }
		public void navigation()
		{
			Console.WriteLine("Enter your choice: ");
			int choice = int.Parse(Console.ReadLine());

			switch (choice)
			{
				case 1:
					Console.Clear();
					search();
					break;
				case 2:
					Console.Clear();
					create();
					break;
				case 3:
					Console.Clear();
					delete();
					break;
				case 4:
					Environment.Exit(0);
					break;
				default:
					Console.WriteLine("Please enter your option: ");
					break;
			}
			
			UserInput ui = new UserInput();
			ui.Display();
		}
		private void search()
		{
			Console.WriteLine("Enter the file name to search: ");
			string fileName = Console.ReadLine();

			if (File.Exists(fileName))
			{
				fileFound(fileName);
			}
			else Console.WriteLine("File does not exist");
		}
		private void fileFound(string fileName) 
		{
			Console.WriteLine("File found");
			UserInput ui = new UserInput();
			ui.DisplayActions();
			Console.WriteLine("Enter choice");
			int choice = int.Parse(Console.ReadLine());

			switch (choice)
			{
				case 1:
					Console.Clear();
					Read read = new Read(fileName);
					read.streamRead();
					break;
				case 2:
					Console.Clear();
					Write write = new Write(fileName);
					write.streamWrite();
					break;
				case 3:
					break;
				default:
					break;
			}
		}
		private void create()
		{
			Console.WriteLine("Enter the file name to create: ");
			string fileName = Console.ReadLine();

			try
			{
				using (FileStream fs = File.Create(fileName))
				{
					Console.WriteLine($"File {fileName} was created.");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine($"An error occurred: {e.Message}");
			}
		}
		private void delete()
		{
			Console.WriteLine("Enter filename to delete: ");
			string filename = Console.ReadLine();


			try
			{
				File.Delete(filename);
				Console.WriteLine($"File {filename} was deleted.");
			}
			catch (Exception e)
			{
				Console.WriteLine($"An error occurred: {e.Message}");
			}

		}
	}
}
