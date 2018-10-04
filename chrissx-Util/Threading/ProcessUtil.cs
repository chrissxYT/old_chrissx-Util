using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace chrissx_Util.Threading
{
    public static class ProcessUtil
    {
        /// <summary>
        /// Starts a new Command Prompt.
        /// </summary>
        /// <param name="cmd">The command(s) to start with</param>
        /// <param name="hide">If the Command Prompt should be hidden</param>
        /// <returns>The STDOUT</returns>
        public static string[] StartCmd(string cmd, bool hide)
        {
            var p = new Process();
            p.StartInfo.WindowStyle = hide ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal;
            p.StartInfo.FileName = "cmd";
            p.StartInfo.Arguments = "/c " + cmd;
            p.StartInfo.RedirectStandardOutput = true;
            List<string> output = new List<string>();
            while (!p.StandardOutput.EndOfStream)
            {
                output.Add(p.StandardOutput.ReadLine());
            }
            return output.ToArray();
        }

        /// <summary>
        /// Sets whether the console window is visible or not
        /// </summary>
        /// <param name="visible">Whether it should be shown or not</param>
        public static void SetVisible(bool visible)
        {
            ShowWindow(GetConsoleWindow(), visible ? 5 : 0);
        }

        /// <summary>
        /// Gets the current console window.
        /// </summary>
        /// <returns>The console window</returns>
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        /// <summary>
        /// Changes if the window is shown or not.
        /// </summary>
        /// <param name="hWnd">The window</param>
        /// <param name="nCmdShow">The int that determines if the window should be shown or not</param>
        /// <returns>I don't know what this value does.</returns>
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public static List<string> InstalledApps
        {
            get
            {
                List<string> Out = new List<string>();
                using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"))
                    foreach (string skName in rk.GetSubKeyNames())
                        using (RegistryKey sk = rk.OpenSubKey(skName))
                            try
                            {
                                Out.Add(sk.GetValue("DisplayName").ToString());
                            }
                            catch { }
                return Out;
            }
        }

        public static List<string> AppsWithPaths
        {
            get
            {
                List<string> l = new List<string>();
                using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths"))
                    foreach (string skn in rk.GetSubKeyNames())
                        using (RegistryKey sk = rk.OpenSubKey(skn))
                            try
                            {
                                l.Add(sk.GetValue("(Standard)").ToString());
                            }
                            catch { }
                return l;
            }
        }

        public static void LaunchProgram(string name)
        {
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths"))
                foreach (string skn in rk.GetSubKeyNames())
                    if (skn.Equals(name))
                        using (RegistryKey sk = rk.OpenSubKey(skn))
                            Process.Start(sk.GetValue("(Standard)").ToString());
        }
    }
}
