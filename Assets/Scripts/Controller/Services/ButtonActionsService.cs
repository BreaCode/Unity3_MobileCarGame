using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U2MFA
{
    internal sealed class ButtonActionsService : IController
    {
        private SceneView _sceneView;
        private MainMenuView _mainMenuView;
        internal ButtonActionsService(SceneView sceneView)
        {
            _sceneView = sceneView;
            _mainMenuView = sceneView.MainMenuView;
        }
        internal void OnChangePageButtonClick(OpenPageButtonView buttonView)
        {
            _sceneView.CurrentPage.SetActive(false);
            _sceneView.CurrentPage = buttonView.PageToOpen;
            _sceneView.CurrentPage.SetActive(true);
        }
        internal void OnOpenPageButtonClick(OpenPageButtonView buttonView)
        {
            buttonView.PageToOpen.SetActive(true);
        }
        internal void OnCloseMenuButtonClick()
        {
            _mainMenuView.gameObject.SetActive(false);
        }
        internal void OnLinkButtonClick(LinkButtonView buttonView)
        {
            Application.OpenURL(buttonView.Link);
        }
    }
}

