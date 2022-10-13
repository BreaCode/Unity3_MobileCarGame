using UnityEngine;

namespace U2MFA
{
    internal sealed class MainMenuView : MonoBehaviour, IView
    {
        [SerializeField] private OpenPageButtonView _startButtonView;
        [SerializeField] private OpenPageButtonView _settingsButtonView;

        internal OpenPageButtonView StartButtonView
        {
            get { return _startButtonView; }
        }
        internal OpenPageButtonView SettingsButtonView
        {
            get { return _settingsButtonView; }
        }



        private void Start()
        {
            if (_startButtonView == null)
            {
                Debug.Log($"in {gameObject.name} CloseButton is null ");
            }
            if (_settingsButtonView == null)
            {
                Debug.Log($"in {gameObject.name} ProfileButtonView is null ");
            }

        }
    }
}

