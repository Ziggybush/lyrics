using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lyrics
{
    public static class TextEffects
    {
        public static async Task TypeWriteAsync(string text, int delayMs = 30, int pauseAfterPunctuation = 150)
        {

            if (text == null) return;

            foreach (char character in text)
            {
                Console.Write(character);
                await Task.Delay(delayMs);

                if (".,!?;:".Contains(character))
                {
                    await Task.Delay(pauseAfterPunctuation);
                }
            }
            Console.WriteLine();
        }

        public static async Task TypeLines(string[] lines, int delayMs = 150, int pauseAfterPunctuation = 6000)
        {
            foreach (var line in lines)
                await TypeWriteAsync(line, delayMs, pauseAfterPunctuation);
        }
    }
}
