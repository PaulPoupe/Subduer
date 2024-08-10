using EntryPoint;

namespace MySceneManagement
{
    public static class CurentScenes
    {
        public static readonly Scene bootstrap = new Scene("Boot strap");
        public static readonly Scene mainMenu = new Scene("Main menu");
        public static readonly Scene game = new Scene("Game");

        static CurentScenes()
        {
            //BootStrapEntryPoint.OnStateUpdated += bootstrap.IsInitStateUpdate;
            MainMenuEntryPoint.OnStateUpdated += mainMenu.IsInitStateUpdate;
            GameEntryPoint.OnStateUpdated += game.IsInitStateUpdate;
        }

    }
}