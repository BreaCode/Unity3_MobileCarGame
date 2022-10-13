using UnityEngine;

namespace U2MFA
{
    internal sealed class SceneView : MonoBehaviour, IView
    {
        [SerializeField] private GameObject _currentPage;
        [SerializeField] private MainMenuView _mainMenuView;
        [SerializeField] private SettingsMenuView _settingsMenuView;

        internal GameObject CurrentPage
        {
            get { return _currentPage; }
            set { _currentPage = value; }
        }
        internal MainMenuView MainMenuView
        {
            get { return _mainMenuView; }
        }
        internal SettingsMenuView SettingsMenuView
        {
            get { return _settingsMenuView; }
        }

        private void Start()
        {
            if (_currentPage == null)
            {
                Debug.Log($"in {gameObject.name} CurrentPage is null ");
            }
            if (_mainMenuView == null)
            {
                Debug.Log($"in {gameObject.name} MainMenuView is null ");
            }
            if (_settingsMenuView == null)
            {
                Debug.Log($"in {gameObject.name} SettingsMenuView is null ");
            }
        }

    }
}

