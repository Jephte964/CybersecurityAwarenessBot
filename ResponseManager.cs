namespace CybersecurityAwarenessBot.Classes
{
    internal class ResponseManager
    {
        public string GetResponse(string input)
        {
            input = input.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(input))
                return "Please type a cybersecurity question.";

            // Greetings
            if (input.Contains("hello") || input.Contains("hi"))
                return "Hello! How can I help you today?";

            if (input.Contains("how are you"))
                return "I'm doing great! I'm ready to help you stay safe online.";

            // Purpose
            if (input.Contains("purpose") || input.Contains("what do you do"))
                return "My purpose is to teach people about cybersecurity and online safety.";

            if (input.Contains("what can i ask"))
                return "Ask me about passwords, phishing, safe browsing, privacy, or scams.";

            // Password safety
            if (input.Contains("password"))
                return "Use strong, unique passwords with at least 12 characters. Include uppercase, lowercase, numbers, and symbols.";

            // Phishing
            if (input.Contains("phishing") || input.Contains("email scam"))
                return "Phishing tricks people into revealing passwords or banking details. Never click suspicious links.";

            // Safe browsing
            if (input.Contains("browse") || input.Contains("website"))
                return "Always check the website URL, look for HTTPS, and avoid downloading files from unknown sites.";

            // Privacy
            if (input.Contains("privacy"))
                return "Protect your privacy by limiting what you share online and using strong account security.";

            // Scam
            if (input.Contains("scam"))
                return "If an offer looks too good to be true, it is probably a scam. Verify before you trust.";

            // Thanks
            if (input.Contains("thank"))
                return "You're welcome! Stay safe online.";

            // Default
            return "I didn't quite understand that. Try asking about passwords, phishing, safe browsing, privacy, or scams.";
        }
    }
}