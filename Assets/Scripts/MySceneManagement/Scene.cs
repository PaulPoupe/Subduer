
namespace MySceneManagement
{
    public class Scene
    {
        public readonly string name;
        public bool isInit;


        public Scene(string name)
        {
            this.name = name;
        }

        public void IsInitStateUpdate(bool initState) => isInit = initState;

    }
}