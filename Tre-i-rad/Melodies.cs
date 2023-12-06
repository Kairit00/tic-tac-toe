using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_i_rad
{
    public class Melodies
    {

        //       Liten melodi för vinnarlåt
        public static void PlayVictoryMelody()
        {
            int[] frequencies = { 261, 329, 392, 440, 392, 349, 329, 293, 261 };
            int[] durations = { 500, 600, 500, 700, 500, 400, 300, 450, 500};

            for (int i = 0; i < frequencies.Length; i++)
            {
                Console.Beep(frequencies[i], durations[i]);
                Thread.Sleep(0);
            }

        }

        //          Melodi för när man förlorat
        public static void PlayLosingMelody()
        {
            int[] frequencies = { 146, 233, 220, 196, 174, 164, 146, 130};
            int[] durations = { 700, 600, 700, 500, 600, 550, 450, 600};

            for (int i = 0; i < frequencies.Length; i++)
            {
                Console.Beep(frequencies[i], durations[i]);
                Thread.Sleep(20); 
            }

        }

        //          Melodi för när det är oavgjort
        public static void PlayitsAdrawMelody()
        {
            int[] frequencies = { 220, 246, 261, 329, 293, 261, 246, 220 };
            int[] durations = {  500, 450, 400, 450, 500, 500, 450, 550 };

            for (int i = 0; i < frequencies.Length; i++)
            {
                Console.Beep(frequencies[i], durations[i]);
                Thread.Sleep(0); 
            }

        }
    }
}
