using osu.Framework;
using osu.Framework.Platform;

namespace Beatfall.Game.Tests
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost("visual-tests"))
            using (var game = new BeatfallTestBrowser())
                host.Run(game);
        }
    }
}
