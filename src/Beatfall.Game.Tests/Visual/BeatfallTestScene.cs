using osu.Framework.Testing;

namespace Beatfall.Game.Tests.Visual
{
    public abstract partial class BeatfallTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new BeatfallTestSceneTestRunner();

        private partial class BeatfallTestSceneTestRunner : BeatfallGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}
