using System;
using System.IO;
using System.Linq;
using System.Threading;


namespace KeyAuth
{
    class Program
    {


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "1928375";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        static string name = "";
        static string ownerid = "";
        static string secret = "";
        static string version = "1.0";

        public static api KeyAuthApp = new api(name, ownerid, secret, version);

        static void Main(string[] args) {
            Console.Title = RandomString(30);
            KeyAuthApp.init();


            string key;
            if (!File.Exists(@"C:\P\" + name))
            {
                Console.Write("\n\n [ your text here ] License Key - ");
                key = Console.ReadLine();
                KeyAuthApp.license(key);
            }
            else
            {
                
            }
            Console.WriteLine("\n\n [ your text here ] Validating Key..");
            Thread.Sleep(1500);
            Console.Write("\n\n [ your text here ] Expires - " + KeyAuthApp.user_data.expiry);
            Thread.Sleep(2500);
            
            
            Console.Clear();

            Console.WriteLine("\n\n [ your text here ] Launch Cheat - 1");
            Console.WriteLine("\n [ your text here ] Launch Unban-Tool - 2");
            Console.Write("\n\n [ your text here ] Option - ");
            string mainop = Console.ReadLine();

            if (mainop == "1")
            {
                Console.Clear();
                Console.WriteLine("\n [ your text here ] Welcome to your text here");
                Thread.Sleep(1500);
                Console.WriteLine("\n\n [ your text here ] Starting your text here ..");
                Thread.Sleep(1500);
                Console.WriteLine("\n\n [ your text here ] Do not close this Window ..");
                Spoofer.Cheat();
                Console.WriteLine("\n\n [ your text here ] Done! Closing..");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else if (mainop == "2")
            {
                Console.Clear();
                Console.Clear();
                Console.WriteLine("\n\n [ your text here ] Preparing");
                Thread.Sleep(1500);
                Console.WriteLine("\n\n [ your text here ] Launching");
                Spoofer.CleanApex();
                Console.WriteLine("\n\n [ your text here ] Done! Closing..");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else if (mainop == "3")
            {
                Console.Clear();
                Console.Clear();
                Console.WriteLine("\n ( your text here ) Activision Spoofer | Sit Back And Dont Touch Anything");
                Spoofer.Cleantemp();
                Thread.Sleep(1500);
                Console.WriteLine("\n\n ( your text here ) Closing Battle.Net..");
                
                Thread.Sleep(1500);
                Console.WriteLine("\n\n ( your text here ) Cleaning..");
                Spoofer.CleanCodCdrive();
                Spoofer.CleanCodDdrive();
                Console.WriteLine("\n\n ( your text here ) Spoofing Diskdrive..");
                Spoofer.Cheat();
                Console.WriteLine("\n\n ( your text here ) Spoofing BIOS..");
                Spoofer.BiosMB();
                Console.WriteLine("\n\n ( your text here ) Spoofing Internet..");
                Spoofer.SpoofMacAdapters();
                Console.WriteLine("\n\n ( your text here ) Done! Closing..");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
        }
    }
}
