using System;
using System.IO;

namespace Day_1.BussinessLogic
{

	internal class Clear
	{
		private string fileName;

		public string FileName { get => fileName; set => fileName = FileName; }

		public Clear() { }

		public Clear(string fileName)
		{
			this.fileName = fileName;
		}

		public void Clear()
		{
			using (FileStream fileStream = File.Create(fileName))
			{
				// File is created and fileStream is properly disposed of after this block
			}
		}
	}
}
