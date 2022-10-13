using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U2MFA
{
    public sealed class MainBeh : MonoBehaviour
    {
        private SceneView _sceneView;
        private Controllers _controllers;

        internal SceneView SceneView
        {
            set { _sceneView = value; }
        }

        internal Controllers Controllers
        {
            set { _controllers = value; }
        }

        public void Initialize()
        {
            ControllersListInitializer.InitializeControllers(_controllers, _sceneView);
        }
        void Start()
        {
            _controllers.Initialization();
        }
        void Update()
        {
            _controllers.Execute(Time.deltaTime);
        }
        private void FixedUpdate()
        {
            _controllers.FixedExecute(Time.fixedDeltaTime);
        }
    }
}

