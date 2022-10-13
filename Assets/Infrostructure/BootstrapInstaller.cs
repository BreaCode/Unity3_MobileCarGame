
using UnityEngine;
using Zenject;

namespace U2MFA
{
    public class BootstrapInstaller : MonoInstaller
    {
        private SceneView _sceneView;
        private Controllers _controllers = new Controllers();
        
        public override void InstallBindings()
        {
            GameObject sceneContext = GameObject.FindWithTag("SceneContext");
            
            if (sceneContext != null)
            {
                sceneContext.TryGetComponent<SceneView>(out _sceneView);
            }

            MainBeh mainBeh = new MainBeh();
            GameObject mainBehObject  = Instantiate(Resources.Load<GameObject>("MainMonoBeh"));
            mainBeh = mainBehObject.GetComponent<MainBeh>();
            mainBeh.SceneView = _sceneView;
            mainBeh.Controllers = _controllers;
            BindButtonActionsService();
            mainBeh.Initialize();



        }

        private void BindButtonActionsService()
        {
            ButtonActionsService buttonActionsController = new ButtonActionsService(_sceneView);
            _controllers.Add(buttonActionsController);
            Container
                .Bind<ButtonActionsService>()
                .FromInstance(buttonActionsController)
                .AsSingle();
        }
    }
}

