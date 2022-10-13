using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U2MFA
{
    internal sealed class OpenPageButtonView : ButtonView
    {
        [SerializeField] GameObject _pageToOpen;

        internal GameObject PageToOpen
        {
            get { return _pageToOpen; }
        }

        private void Start()
        {
            if (_pageToOpen == null)
            {
                Debug.Log($"{gameObject.name} PageToOpen is null ");
            }
        }
    }

}
