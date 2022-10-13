namespace U2MFA
{
    internal sealed class ControllersListInitializer
    {
        internal static void InitializeControllers(Controllers controllers, SceneView sceneView)
        {
            MenuButtonsController menuButtonsInitializationController = new MenuButtonsController(sceneView);
            

            
            controllers.Add(menuButtonsInitializationController);

        }
    }
}

