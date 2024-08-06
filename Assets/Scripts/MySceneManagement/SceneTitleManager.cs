
namespace MySceneManagement
{
    public static class SceneTitleManager
    {
        public static readonly Scene game = new Scene("Game");
        public static readonly Scene mainMenu = new Scene("Main menu");

        static SceneTitleManager()
        {
            GameEntryPoint.OnStateUpdated += game.isInitStateUpdate;
            MainMenuEntryPoint.OnUpdated += mainMenu.isInitStateUpdate;
        }

    }
}