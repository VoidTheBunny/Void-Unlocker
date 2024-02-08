using System;
using System.Diagnostics;

namespace VoidUnlocker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Clear the console
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
 __     __           __        __        __    __            __                      __                           
/  |   /  |         /  |      /  |      /  |  /  |          /  |                    /  |                          
$$ |   $$ | ______  $$/   ____$$ |      $$ |  $$ | _______  $$ |  ______    _______ $$ |   __   ______    ______  
$$ |   $$ |/      \ /  | /    $$ |      $$ |  $$ |/       \ $$ | /      \  /       |$$ |  /  | /      \  /      \ 
$$  \ /$$//$$$$$$  |$$ |/$$$$$$$ |      $$ |  $$ |$$$$$$$  |$$ |/$$$$$$  |/$$$$$$$/ $$ |_/$$/ /$$$$$$  |/$$$$$$  |
 $$  /$$/ $$ |  $$ |$$ |$$ |  $$ |      $$ |  $$ |$$ |  $$ |$$ |$$ |  $$ |$$ |      $$   $$<  $$    $$ |$$ |  $$/ 
  $$ $$/  $$ \__$$ |$$ |$$ \__$$ |      $$ \__$$ |$$ |  $$ |$$ |$$ \__$$ |$$ \_____ $$$$$$  \ $$$$$$$$/ $$ |      
   $$$/   $$    $$/ $$ |$$    $$ |      $$    $$/ $$ |  $$ |$$ |$$    $$/ $$       |$$ | $$  |$$       |$$ |      
    $/     $$$$$$/  $$/  $$$$$$$/        $$$$$$/  $$/   $$/ $$/  $$$$$$/   $$$$$$$/ $$/   $$/  $$$$$$$/ $$/       
                                                                                                                  
                                                                                                                   ");
            Console.ResetColor();

            Console.WriteLine("Welcome to Void Unlocker!");
            Console.WriteLine("Please select an option: (Recommended to use gui as prompt can be very confusing and buggy)");
            Console.WriteLine("1. Use GUI VERISON");
            Console.WriteLine("2. Use prompt version");

            ConsoleKeyInfo keyPressed;
            do
            {
                keyPressed = Console.ReadKey();
                Console.WriteLine();
                switch (keyPressed.KeyChar)
                {
                    case '1':
                        Console.WriteLine("Using gui version...");
                        RunGuiVersion();
                        break;
                    case '2':
                        Console.Clear(); 
                        Console.WriteLine("Using prompt version...");
                        RunPromptVersion(); 
                        
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (keyPressed.KeyChar != '1' && keyPressed.KeyChar != '2');

            Console.WriteLine("Thank you. Press any key to exit...");
            Console.ReadKey();
        }

        static void RunGuiVersion()
        }
            System.Windows.Forms.Application.Run(new guiversion());

        }

        static void RunPromptVersion()
        {
            var prompt = new DisplayPrompt();
            prompt.Run();
        }
    }
}
