using osu.Framework.Platform;
using osu.Framework;
using Beatfall.Game;

namespace Beatfall.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost(@"Beatfall"))
            using (osu.Framework.Game game = new BeatfallGame())
                host.Run(game);
        }
    }
}
