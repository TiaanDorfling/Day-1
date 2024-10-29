using System;
using System.IO;

namespace Day_1.BussinessLogic
{
	internal class Read
	{
		private string fileName;

		public string FileName { get => fileName; set => fileName = FileName; }
		public Read() { }

		public Read(string fileName)
		{
			this.fileName = fileName;
		}

		public void streamRead()
		{
			Console.WriteLine($"Text in file {fileName}: ");

			using (StreamReader streamReader = new StreamReader(fileName))
			{
				string txt;
				while ((txt = streamReader.ReadLine()) != null)
				{
					Console.WriteLine(txt);
				}
			}
		}
	}
}
