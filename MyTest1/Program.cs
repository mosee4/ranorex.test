/*
 * Created by Ranorex
 * User: vitaliy.moseev
 * Date: 27.01.2020
 * Time: 17:34
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */

using System;
using System.Windows.Forms;

namespace MyTest1
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
