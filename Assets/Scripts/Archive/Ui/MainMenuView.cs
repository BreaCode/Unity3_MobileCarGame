using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui
{
    public class MainMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonStart;


        public void Init(UnityAction startGame) =>
            _buttonStart.onClick.AddListener(startGame);

        public void OnDestroy() =>
            _buttonStart.onClick.RemoveAllListeners();
    }
}
