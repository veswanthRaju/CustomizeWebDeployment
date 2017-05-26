using System;
using System.Diagnostics;

namespace AutomateWebDeployment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to start WinScp application Y/N");
            var launchWinSCP = Console.ReadLine();
            if (launchWinSCP.ToLower() == "y")
            {
                OpenExternalApplcation(@"C:\Program Files (x86)\WinSCP\WinSCP.exe", "winscp");
                Console.WriteLine("WinSCP Launched..");
                OpenExternalApplcation(@"C:\Windows\Sysnative\putty.exe", "putty");
                Console.WriteLine("Putty Launched..");
            }
            else
                Console.WriteLine("Not Opening");
            Console.ReadLine();
        }

        #region Private Methods
        private static void OpenExternalApplcation(string appPath, string appName)
        {
            if (appName == "winscp")
            {
                //Giving arguments to the launched application
                Process p = Process.Start(appPath, "10.10.0.177 2222 gumstix gumstix");
            }
            else
            {
                Process p = Process.Start(appPath, "10.10.0.177 2222");
            }
        }
        #endregion
    }

    #region Useful code

    //OpenExternalApplcation(@"C:\Program Files\Dell SonicWALL\Global VPN Client\SWGVC.exe");
    //Console.WriteLine("VPN client Launched..");

    //ProcessStartInfo info = new ProcessStartInfo();
    //You should need to place the .exe file in the ‪C:\Windows\System32 Location
    //info.FileName = appPath;

    //info.Arguments = "olaa"; //argument
    //info.UseShellExecute = false;
    //info.RedirectStandardOutput = true;
    //info.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
    //info.CreateNoWindow = true; //not diplay a windows
    #endregion
}