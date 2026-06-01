using System;
using System.Media;

namespace WinFormsApp1.Models
{
    public static class PlaySound
    {
        // Using the absolute path directly as per Microsoft documentation
        // Changed 'chimes.wav' to 'Windows Navigation Start.wav' for a more mechanical relay click feel
        private static SoundPlayer player = new SoundPlayer(@"C:\Windows\Media\Windows Navigation Start.wav");

        public static void Play()
        {
            try
            {
                // Play() is natively asynchronous and will not freeze the CPU clock or UI
                player.Play();
            }
            catch(Exception exp)
            {
                // Failsafe in case the Windows installation is missing the file
                Console.Write(exp.Message);   
            }
        }
    }
}