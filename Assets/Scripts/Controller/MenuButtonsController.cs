using Zenject;

namespace U2MFA
{
    internal sealed class MenuButtonsController : IController, IInitialization
    {
        private MainMenuView _mainMenuView;
        private ButtonActionsService _buttonActions;

        internal MenuButtonsController(SceneView sceneView)
        {
            _mainMenuView = sceneView.MainMenuView;
        }

        [Inject]
        public void Construct(ButtonActionsService buttonActionsService)
        {
            _buttonActions = buttonActionsService;
        }
        
        public void Initialization()
        {
            _mainMenuView.StartButtonView.Button.onClick.AddListener(() => _buttonActions.OnChangePageButtonClick(_mainMenuView.StartButtonView));
            _mainMenuView.SettingsButtonView.Button.onClick.AddListener(() => _buttonActions.OnChangePageButtonClick(_mainMenuView.SettingsButtonView));

        }
    }
}

