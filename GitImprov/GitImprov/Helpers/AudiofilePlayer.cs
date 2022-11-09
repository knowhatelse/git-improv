using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GitImprov.Helpers
{
    internal class AudiofilePlayer
    {
        //TO DO:
        //Load audiofile - DONE
        //Play audiofile - DONE
        //Stop audiofile - DONE
        //Recentley played - X

        //Private properties
        private static string? AudiofilePath { get; set; }

        private static SoundPlayer soundPlayer = new SoundPlayer();

        //Public properties
        public static bool Loop { get; set; } = false;


        //Private methods
        private static void GetAndPlayAudiofile()
        {
            if (string.IsNullOrEmpty(AudiofilePath) != true)
            {
                soundPlayer.SoundLocation = AudiofilePath;
                if (Loop) { soundPlayer.PlayLooping(); } else { soundPlayer.Play(); }
            }
            else
            {
                MessageBox.Show(
                    "Audiofile is not loaded! Please, loade the audiofile first",
                    "File not loaded",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        //Public methods
        public static void Load()
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    AudiofilePath = ofd.FileName;
                }
            }
        }

        public static async Task Play()
        {
            await Task.Run(() => GetAndPlayAudiofile());
        }

        public static void Stop()
        {
            soundPlayer.Stop();
            soundPlayer.Dispose();
        }
    }
}
