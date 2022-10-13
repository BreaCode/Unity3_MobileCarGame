using UnityEngine;

namespace U2MFA
{
    internal sealed class LinkButtonView : ButtonView
    {
        [SerializeField] private string _link;

        public string Link
        {
            get { return _link; }
        }

        private void Start()
        {
            if (_link == null)
            {
                Debug.Log($"{gameObject.name} Link is null ");
            }
        }
    }
}

