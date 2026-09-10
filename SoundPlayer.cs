using System;
using System.IO;
using System.Media;

namespace CybersecurityAwarenessBot.Classes
{
    internal class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                string audioPath = Path.Combine("Audio", "greeting.wav");

                if (File.Exists(audioPath))
                {
                    SoundPlayer player = new SoundPlayer(audioPath);
                    player.PlaySync();
                }
            }
            catch
            {
                Console.WriteLine("Unable to play the greeting audio.");
            }
        }
    }
}