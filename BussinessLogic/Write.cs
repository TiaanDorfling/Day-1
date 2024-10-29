using System;
using System.IO;

namespace Day_1.BussinessLogic
{
	internal class Write
	{
		private string fileName;

		public string FileName { get => fileName; set => fileName = FileName; }
		public Write() { }

		public Write(string fileName)
		{
			this.fileName = fileName;
		}

		public void streamWrite()
		{
			Console.WriteLine("Enter the text: ");
			string text = Console.ReadLine();

			//true parameter makes the file append not rewrite
			using (StreamWriter streamWriter = new StreamWriter(fileName, true))
			{
				streamWriter.WriteLine(text);
			}

			Console.WriteLine("Text saved.");
		}
	}
}
