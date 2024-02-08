using System;
using System.Diagnostics;
using System.IO;

namespace VoidUnlocker
{
    public class DisplayPrompt
    {
        private const string SoundsDirectory = "Sounds";
        private const string OldDeathSound = "ouch old.ogg";
        private const string NewDeathSound = "ouch new.ogg";

        public void Run()
        {
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

            Console.WriteLine("Welcome to Void Unlocker!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Sound options");

            ConsoleKeyInfo keyPressed;
            do
            {
                keyPressed = Console.ReadKey();
                Console.WriteLine();
                switch (keyPressed.KeyChar)
                {
                    case '1':
                        SoundOptions();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (keyPressed.KeyChar != '1');

            Console.WriteLine("Thank you. Press any key to exit...");
            Console.ReadKey();
        }

        private void SoundOptions()
        {
            Console.WriteLine("Opening sound options...");
            Console.WriteLine("2. Change death sound to new death sound");
            Console.WriteLine("3. Change death sound to old death sound");

            ConsoleKeyInfo keyPressed;
            do
            {
                keyPressed = Console.ReadKey();
                Console.WriteLine();
                switch (keyPressed.KeyChar)
                {
                    case '2':
                        ChangeDeathSound(NewDeathSound);
                        break;
                    case '3':
                        ChangeDeathSound(OldDeathSound);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (keyPressed.KeyChar != '2' && keyPressed.KeyChar != '3');
        }

        private void ChangeDeathSound(string newDeathSound)
        {
            Console.WriteLine($"Changing death sound to {newDeathSound}...");
            ClearConsole();

            Console.WriteLine($"Death sound changed to {newDeathSound}.");
        }

        private void ClearConsole()
        {
            Console.Clear();
            
        }
    }
}
