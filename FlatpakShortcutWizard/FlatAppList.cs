using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace FlatpakShortcutWizard
{
	public class FlatAppList
	{
		public FlatAppList()
		{
		}

		public List<FlatAppItem> GetFlatAppList()
		{
		    var retList=new List<FlatAppItem>();

			try
			{

				var p = new Process();

				var basepath = AppDomain.CurrentDomain.BaseDirectory;
 
				p.StartInfo.WorkingDirectory = "/usr/bin";
				p.StartInfo.FileName = "/bin/bash";//"/bin/sh"; "/usr/bin/flatpak"; //shpath;
				p.StartInfo.Arguments = " -c \"ls ~/.local/share/flatpak/app/\"";
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.LoadUserProfile = true;
				p.StartInfo.CreateNoWindow = false;
				//p.StartInfo.RedirectStandardInput = true;
				p.StartInfo.RedirectStandardOutput = true;
				p.StartInfo.RedirectStandardError = true;
 
				p.Start();
 
				p.WaitForExit();
				var retstring = p.StandardOutput.ReadToEnd();
				var errinfo = p.StandardError.ReadToEnd();
				p.Close();
				Console.WriteLine(retstring);
				Console.WriteLine(errinfo);

				var listRet = retstring.Split(Environment.NewLine.ToCharArray());

				foreach (var s in listRet)
				{
					if (!string.IsNullOrEmpty(s))
					{
						retList.Add(new FlatAppItem() { AppName = s });
					}
				}

			}
			catch (Exception ex)
			{
				var msg = ex.Message;
				Console.WriteLine(msg);
			}
		    return retList;
		}


		public void CreateShortcut(string appname)
		{
			var deskpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			var shortcutfmt = "#!/usr/bin/env xdg-open\n[Desktop Entry]\nEncoding=UTF-8\nVersion=1.0\nName={0}\nGenericName={1}.flatpak\nExec=flatpak run {2}\nTerminal=false\nIcon=\nType=Application\nComment={3}\nCategories=Application;\n";

			var shutcutstring=string.Format(shortcutfmt, appname, appname, appname, appname);

			var shutfilename = appname + ".desktop";
			var shutfilepath = Path.Combine(deskpath, shutfilename);

			File.WriteAllText(shutfilepath, shutcutstring);

			SetFileExecuteable(shutfilepath);
		}

		void SetFileExecuteable(string filePath)
		{
			try
			{
				var p = new Process();
				p.StartInfo.WorkingDirectory = "/usr/bin";
				p.StartInfo.FileName = "/bin/bash";//"/bin/sh"; "/usr/bin/flatpak"; //shpath;
				p.StartInfo.Arguments = " -c \"chmod +x "+filePath+"\"";
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.LoadUserProfile = true;
				p.StartInfo.CreateNoWindow = false;
				//p.StartInfo.RedirectStandardInput = true;
				p.StartInfo.RedirectStandardOutput = true;
				p.StartInfo.RedirectStandardError = true;
 

				p.Start();
 
				p.WaitForExit();
				p.Close();
			}
			catch (Exception ex){
				var msg = ex.Message;
			}
		}
	}
}
