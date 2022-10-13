using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U2MFA
{
    internal class SettingsMenuView : MonoBehaviour
    {
        [SerializeField] private OpenPageButtonView _settingsButtonView;

        internal OpenPageButtonView SettingsButtonView
        {
            get { return _settingsButtonView; }
        }



        private void Start()
        {
            if (_settingsButtonView == null)
            {
                Debug.Log($"in {gameObject.name} ProfileButtonView is null ");
            }
        }
    }
}

