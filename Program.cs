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
                        Console.Clear(); // Clear the console before running the prompt version
                        Console.WriteLine("Using prompt version...");
                        RunPromptVersion(); // Call the method to run the prompt version
                        // For now, let's just exit
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
        {
            // Assuming the GUI version is part of the same executable,
            // we can simply start a new process with the same executable.
            System.Windows.Forms.Application.Run(new guiversion());

        }

        static void RunPromptVersion()
        {
            // Assuming Prompt.cs is in the same namespace and contains a class named Prompt
            var prompt = new DisplayPrompt();
            prompt.Run();
        }
    }
}
