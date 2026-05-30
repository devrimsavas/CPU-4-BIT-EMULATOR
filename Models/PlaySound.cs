using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media; 

namespace WinFormsApp1.Models
{
    public static class PlaySound
    {
        public static string PlaySoundName { get;set; } =string.Empty;
        public static SoundPlayer player = new SoundPlayer("ss");  
        public static void Play()
        {
            string soundFilePath="./relay.wav"; 

        }
    }
}
