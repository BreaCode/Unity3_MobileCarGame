using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace U2MFA
{
    internal class ButtonView : MonoBehaviour, IView
    {
        [SerializeField] Button _button;
        [SerializeField] TMP_Text _text;
        [SerializeField] bool _noText;

        internal Button Button
        {
            get { return _button; }
        }
        internal TMP_Text Text
        {
            get { return _text; }
        }

        private void Start()
        {
            if (_button == null)
            {
                Debug.Log($"{gameObject.name} button is null ");
            }
            if (_text == null && _noText != true)
            {
                Debug.Log($"{gameObject.name} text is null ");
            }
        }
    }
}

