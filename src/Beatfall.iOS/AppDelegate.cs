using osu.Framework.iOS;
using Beatfall.Game;

namespace Beatfall.iOS
{
    /// <inheritdoc />
    public class AppDelegate : GameApplicationDelegate
    {
        /// <inheritdoc />
        protected override osu.Framework.Game CreateGame() => new BeatfallGame();
    }
}
