namespace CybersecurityAwarenessBot.Classes
{
    internal class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                string audioPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Audio",
                    "greeting.wav"
                );

                if (File.Exists(audioPath))
                {
                    using (SoundPlayer player = new SoundPlayer(audioPath))
                    {
                        player.PlaySync();
                    }
                }
                else
                {
                    Console.WriteLine("Audio file not found: " + audioPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing audio: " + ex.Message);
            }
        }
    }
}
