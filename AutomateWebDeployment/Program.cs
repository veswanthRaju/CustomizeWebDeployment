using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateWebDeployment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to start WinScp application Y/N");
            var launchWinSCP = Console.ReadLine();
            if (launchWinSCP == "y" || launchWinSCP == "Y")
            {
                OpenExternalApplcation(@"C:\Windows\Sysnative\WinSCP.exe");
                Console.WriteLine("WinSCP Launched..");
                OpenExternalApplcation(@"C:\Windows\Sysnative\putty.exe");
                Console.WriteLine("Putty Launched..");
            }
            else
                Console.WriteLine("Not Opening");
            Console.ReadLine();
        }

        private static void OpenExternalApplcation(string appPath)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            //You should need to place the exe file in the ‪C:\Windows\System32 Location
            info.FileName = appPath;
            Process p = Process.Start(info);
        }
    }
}
