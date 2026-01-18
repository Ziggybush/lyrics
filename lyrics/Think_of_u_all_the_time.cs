using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lyrics
{
    public class Think_of_u_all_the_time
    {
        public static async Task thinkOfU()
        {
            await TextEffects.TypeLines(new string[]
            {
                "...",
                "I think of you all the time",
                "You're always on my mind",
                "But I can't get you out my head",
                "I'd rather burn instead"
            });
        }
    }
}
