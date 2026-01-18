using System.Reflection;

namespace lyrics
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Lyrics";
            await Never_enough.neverEnough();
            //await Maybe_i_m_worth_a_smile.worthASmile();
            //await Think_of_u_all_the_time.thinkOfU();
            Console.ReadKey();
        }
    }
}
