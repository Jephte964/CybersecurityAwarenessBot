using System;
using System.Threading;

namespace CybersecurityAwarenessBot.Classes
{
    internal class UIHelper
    {
        public static void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            ShowDateTime();

            Console.WriteLine("======================================================");
            Console.WriteLine("          CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("======================================================");
            Console.WriteLine("                  .--------.");
            Console.WriteLine("                 /  .----.  \\");
            Console.WriteLine("                |  /      \\  |");
            Console.WriteLine("                | |  LOCK  | |");
            Console.WriteLine("                |  \\      /  |");
            Console.WriteLine("                 \\  '----'  /");
            Console.WriteLine("                  '--------'");
            Console.WriteLine("======================================================");

            Console.ResetColor();
            Console.WriteLine();
        }

        public static void ShowDateTime()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Date: {DateTime.Now:dd MMMM yyyy}");
            Console.WriteLine($"Time: {DateTime.Now:HH:mm:ss}");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void ShowDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("------------------------------------------------------");
            Console.ResetColor();
        }

        public static void TypeWriter(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (char letter in message)
            {
                Console.Write(letter);
                Thread.Sleep(25);
            }

            Console.WriteLine();
            Console.ResetColor();
        }

        public static void ShowBotMessage(string message)
        {
            Console.Write("Bot: ");
            TypeWriter(message);
        }

        public static void ShowUserPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You: ");
            Console.ResetColor();
        }
    }
}