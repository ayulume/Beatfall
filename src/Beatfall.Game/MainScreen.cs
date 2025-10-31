using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Textures;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Screens;
using osu.Framework.Extensions.Color4Extensions;
using osuTK.Graphics;

namespace Beatfall.Game
{
    public partial class MainScreen : Screen
    {
        [BackgroundDependencyLoader]
        private void load(TextureStore textures)
        {
            InternalChildren =
            [
                new Box
                {
                    Colour = Color4.Black,
                    RelativeSizeAxes = Axes.Both,
                },
                new Sprite
                {
                    Texture = textures.Get("logo"),
                    RelativeSizeAxes = Axes.None,
                    Size = new osuTK.Vector2(447, 345.07f),
                    Anchor = Anchor.CentreRight,
                    Origin = Anchor.CentreRight,
                    X = -20,
                    FillMode = FillMode.Fit,
                },
                new Box
                {
                    Anchor = Anchor.BottomLeft,
                    Origin = Anchor.BottomLeft,
                    RelativeSizeAxes = Axes.X,
                    Height = 30,
                    Colour = Color4Extensions.FromHex("212121"),
                },
                new SpriteText
                {
                    Y = 0,
                    X = 2,
                    Text = "Welcome to Beatfall!",
                    Anchor = Anchor.BottomLeft,
                    Origin = Anchor.BottomLeft,
                    Font = FontUsage.Default.With(size: 30)
                },
                new BasicButton
                {
                    Anchor = Anchor.BottomRight,
                    Origin = Anchor.BottomRight,
                    Text = "Quit",
                    Size = new osuTK.Vector2(100, 40),
                    Margin = new MarginPadding { Right = 10, Bottom = 40 },
                    Action = quitGame
                }
            ];
        }

        private void quitGame()
        {
            System.Environment.Exit(0);
        }
    }
}
