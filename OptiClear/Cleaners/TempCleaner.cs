using System;
using System.IO;
using System.Windows.Forms;

namespace OptiClear.Cleaners
{
	public class TempCleaner
	{
		public void Clean()
		{
			// Clean temp files
			var tempPath = Path.GetTempPath();
			var tempFiles = Directory.GetFiles(tempPath);

			foreach (var file in tempFiles)
			{
				try
				{
					File.Delete(file);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}

		}
	}
}