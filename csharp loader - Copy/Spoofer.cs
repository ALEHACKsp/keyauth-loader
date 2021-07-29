using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeyAuth
{
	class Spoofer
	{
		public static void Cheat()
		{
			WebClient webClient = new WebClient();
			string text = @"";
			string text2 = @"";
			string text3 = @"";
			webClient.DownloadFile("", text);
			webClient.DownloadFile("", text2);
			webClient.DownloadFile("", text3);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text3);
			process.WaitForExit();
			File.Delete(");
			File.Delete("");
			File.Delete("");
			Thread.Sleep(1000);
			
			
		}
		public static void SpoofHDD()
		{
			WebClient webClient = new WebClient();
			string text = @"C:\Windows\IME\kdmapper.exe";
			string text2 = @"C:\Windows\IME\spoof.sys";
			webClient.DownloadFile("", text2);
			webClient.DownloadFile("", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text, text2);
			Thread.Sleep(1000);
			process.Close();
			File.Delete("C:\\Windows\\IME\\kdmapper.exe.sys");
			File.Delete("C:\\Windows\\IME\\spoof.sys");
		}
		public static void CheckHWID()
		{
			WebClient webClient = new WebClient();
			string text = @"C:\Windows\Web\explorer.exe";
			Process process = new Process();
			webClient.DownloadFile("", text);
			Process process2 = Process.Start("C:\\Windows\\Web\\check.bat");
			process2.WaitForExit();
			File.Delete("C:\\Windows\\Web\\check.bat");
		}
		public static void spoofmain()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\SysWOW64\\wbem\\ncdll.sys";
			string text2 = "C:\\Windows\\SysWOW64\\wbem\\stoper.exe";
			string text3 = "C:\\Windows\\SysWOW64\\wbem\\drmc.sys";
			string text4 = "C:\\Windows\\SysWOW64\\wbem\\system64.bat";
			Process process = new Process();
			webClient.DownloadFile("", text);
			webClient.DownloadFile("", text2);
			webClient.DownloadFile("", text3);
			webClient.DownloadFile("", text4);
			Process process2 = Process.Start("C:\\Windows\\SysWOW64\\wbem\\system64.bat");
			process2.WaitForExit();
			
		}
		public static void CleanApex()
		{
			string text = "C:\\Windows\\Web\\map.exe";
			WebClient D = new WebClient();
			D.DownloadFile("", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.FileName = "C:\\Windows\\Web\\map.exe";
			process.Start();
			File.Delete("C:\\Windows\\Web\\map.exe");
		}
		public static void CleanEvents()
		{
			string text = "C:\\Windows\\SysWOW64\\wbem\\AdvancedEventCleaner.exe";
			WebClient D = new WebClient();
			D.DownloadFile("", text);
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\AdvancedEventCleaner.exe";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\AdvancedEventCleaner.exe");
		}
		public static void BiosMB()
		{
			string text = "C:\\Windows\\SysWOW64\\wbem\\more.exe";
			WebClient D = new WebClient();
			D.DownloadFile("", text);
			Process process = new Process();
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\more.exe";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\more.exe");
		}
		public static void ActivateWindows()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\ProgramData\\Activation.exe";
			Process process = new Process();
			webClient.DownloadFile("", text);
			Process process2 = Process.Start("C:\\ProgramData\\Activation.exe");
			process2.WaitForExit();
			File.Delete("C:\\ProgramData\\Activation.exe");
		}
		public static void DeepClean()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\ProgramData\\clean1.bat";
			string text2 = "C:\\ProgramData\\clean2.bat";
			string text3 = "C:\\ProgramData\\clean3.bat";
			string text4 = "C:\\ProgramData\\clean4.bat";
			Process process = new Process();
			webClient.DownloadFile("", text);
			webClient.DownloadFile("", text2);
			webClient.DownloadFile("", text3);
			webClient.DownloadFile("", text4);
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = false;
			Process process2 = Process.Start("C:\\ProgramData\\clean1.bat");
			Process.Start("C:\\ProgramData\\clean2.bat");
			Process.Start("C:\\ProgramData\\clean3.bat");
			Process.Start("C:\\ProgramData\\clean4.bat");
			process2.WaitForExit();
			File.Delete("C:\\ProgramData\\clean1.bat");
			File.Delete("C:\\ProgramData\\clean2.bat");
			File.Delete("C:\\ProgramData\\clean3.bat");
			File.Delete("C:\\ProgramData\\clean4.bat");
		}
		public static void SpoofMacAdapters()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\SysWOW64\\wbem\\mac.exe";
			webClient.DownloadFile("", text);
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\mac.exe";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\mac.exe");
		}
		public static void Cleantemp()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\SysWOW64\\wbem\\CleanTemp.bat";
			webClient.DownloadFile("", text);
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\CleanTemp.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\CleanTemp.bat");
		}
		public static void CleanCodCdrive()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\SysWOW64\\wbem\\C_DRIVE.bat";
			webClient.DownloadFile("", text);
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\C_DRIVE.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\C_DRIVE.bat");
		}
		public static void CleanCodDdrive()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\SysWOW64\\wbem\\D_DRIVE.bat";
			webClient.DownloadFile("", text);
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\D_DRIVE.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\D_DRIVE.bat");
		}
		public static void Adapters()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\SysWOW64\\Adapters.exe";
			string text2 = "C:\\Windows\\SysWOW64\\x64Threads.dll";
			webClient.DownloadFile("", text);
			webClient.DownloadFile(", text2);
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\Adapters.exe";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\Adapters.exe");
		}
		public static void Adapters2()
		{
			WebClient webClient = new WebClient();
			string text = @"C:\Windows\SysWOW64\roka.exe";
			string text2 = @"C:\Windows\SysWOW64\nig.dll";
			webClient.DownloadFile("", text);
			webClient.DownloadFile("", text2);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text);
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\roka.exe");
			File.Delete("C:\\Windows\\SysWOW64\\nig.dll");
			Thread.Sleep(1000);

		}
		public static void CleanApexLegends()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\SysWOW64\\wbem\\CleanApex.bat";
			webClient.DownloadFile("", text);
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\CleanApex.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\CleanApex.bat");
		}
		public static void CleanFortnitee()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\SysWOW64\\wbem\\clean_fortnite.bat";
			webClient.DownloadFile("", text);
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\clean_fortnite.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\clean_fortnite.bat");
		}
		public static void applecleanfn()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\SysWOW64\\wbem\\apple.exe";
			webClient.DownloadFile("", text);
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\apple.exe";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\apple.exe");
		}
	}
}











