namespace CybersecurityAwarenessBot.Classes
{
    internal class ChatBot
    {
        private readonly ResponseManager responseManager;

        public ChatBot()
        {
            responseManager = new ResponseManager();
        }

        public void Start()
        {
            AudioPlayer.PlayGreeting();
            UIHelper.ShowHeader();

            UIHelper.ShowBotMessage("Hello! Welcome to the Cybersecurity Awareness Bot.");
            UIHelper.ShowBotMessage("What is your name?");

            UIHelper.ShowUserPrompt();
            string? userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
                userName = "User";

            bool running = true;

            while (running)
            {
                Console.Clear();
                UIHelper.ShowHeader();

                UIHelper.ShowBotMessage($"Welcome, {userName}!");
                UIHelper.ShowDivider();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Password Safety");
                Console.WriteLine("2. Phishing");
                Console.WriteLine("3. Safe Browsing");
                Console.WriteLine("4. Ask Your Own Question");
                Console.WriteLine("5. Exit");
                Console.ResetColor();

                UIHelper.ShowDivider();
                Console.Write("Choose an option (1-5): ");
                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        UIHelper.ShowBotMessage(responseManager.GetResponse("password"));
                        break;

                    case "2":
                        UIHelper.ShowBotMessage(responseManager.GetResponse("phishing"));
                        break;

                    case "3":
                        UIHelper.ShowBotMessage(responseManager.GetResponse("browse"));
                        break;

                    case "4":
                        UIHelper.ShowBotMessage("Ask me anything about cybersecurity:");
                        UIHelper.ShowUserPrompt();
                        string? question = Console.ReadLine();
                        UIHelper.ShowBotMessage(responseManager.GetResponse(question ?? ""));
                        break;

                    case "5":
                        UIHelper.ShowBotMessage($"Goodbye, {userName}! Stay safe online.");
                        running = false;
                        continue;

                    default:
                        UIHelper.ShowBotMessage("Invalid option. Please choose 1 to 5.");
                        break;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Press any key to return to the menu...");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}