
namespace MySceneManagement
{
    public static class SceneTitleManager
    {
        public static readonly Scene game = new Scene("Game");
        public static readonly Scene mainMenu = new Scene("Main menu");

        static SceneTitleManager()
        {
            GameEntryPoint.OnUpdated += game.SetIsInit;
            MainMenuEntryPoint.OnUpdated += mainMenu.SetIsInit;
        }

    }
}