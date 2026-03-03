using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http
namespace dctool
{

    interval class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "dctool";
            white (true)
            {
            Console.Clear();
            Console.Title = "dctool";
            Banner();
            Menu();

            ConsoleKeyInfo input = Console.ReadKey();
            char option = input.char;
            Console.writeline(option);
            switch (option)
            {
                    
                case '1':
                    webhookMessage();
                    break;
                case '4':
                    return;
            }
            }
        }


        static void Banner()
        {
            Console.foregroundcolor = ConsoleColor.LimeGreen;
            Console.writeline(@"
 ________  ________  ________  ________  ________  ___    
|\   ___ \|\   ____\\___   ___\\   __  \|\   __  \|\  \         
\ \  \_|\ \ \  \___\|___ \  \_\ \  \|\  \ \  \|\  \ \  \        
 \ \  \ \\ \ \  \       \ \  \ \ \  \\\  \ \  \\\  \ \  \       
  \ \  \_\\ \ \  \____   \ \  \ \ \  \\\  \ \  \\\  \ \  \____  
   \ \_______\ \_______\  \ \__\ \ \_______\ \_______\ \_______\
    \|_______|\|_______|   \|__|  \|_______|\|_______|\|_______|
                                                            - @18Dev_
");
        Console.ResetColor();
        }

        static void Menu()
        {
            Console.writeline("\n1. Send Webhook Message");
            Console.writeline("2. Veiw Guild Info");
            Console.writeline("3. Check Member Status");
            Console.writeline("4. Exit");
        }

        static async void WebHook Message()
        {
            Console.clear();
            Console.write("WebHook URL: ");
            string webhook = Console.ReadLine();

            Console.write("message: ");
            string message = Console.ReadLine();

            string json $"{{\"content\": \"{message}\"}}";

            using (HttpClient client = new HttpClient()) {
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await Client.PostAsync(webhook, content).wait();
            }
        }
    }   

}
