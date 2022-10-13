using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U2MFA
{
    internal sealed class Controllers :  IInitialization, IExecute, IFixedExecute, ILateExecute, ICleanup
    {
        private readonly List<IInitialization> _initializeControllers;
        private readonly List<IExecute> _executeControllers;
        private readonly List<IFixedExecute> _fixedControllers;
        private readonly List<ILateExecute> _lateControllers;
        private readonly List<ICleanup> _cleanupControllers;

        internal int InitializeControllersCount
        {
            get { return _initializeControllers.Count; }
        }
        internal int ExecuteControllersCount
        {
            get { return _executeControllers.Count; }
        }
        internal int FixedControllersCount
        {
            get { return _fixedControllers.Count; }
        }
        internal int LateControllersCount
        {
            get { return _lateControllers.Count; }
        }
        internal int CleanupControllersCount
        {
            get { return _cleanupControllers.Count; }
        }

        internal Controllers()
        {
            _initializeControllers = new List<IInitialization>(8);
            _executeControllers = new List<IExecute>(8);
            _fixedControllers = new List<IFixedExecute>(8);
            _lateControllers = new List<ILateExecute>(8);
            _cleanupControllers = new List<ICleanup>(8);
        }

        internal Controllers Add(IController controller)
        {
            if (controller is IInitialization initializeController)
            {
                _initializeControllers.Add(initializeController);
            }

            if (controller is IExecute executeController)
            {
                _executeControllers.Add(executeController);
            }

            if (controller is IFixedExecute fixedExecuteController)
            {
                _fixedControllers.Add(fixedExecuteController);
            }

            if (controller is ILateExecute lateExecuteController)
            {
                _lateControllers.Add(lateExecuteController);
            }

            if (controller is ICleanup cleanupController)
            {
                _cleanupControllers.Add(cleanupController);
            }

            return this;
        }

        public void Initialization()
        {
            for (var i = 0; i < _initializeControllers.Count; ++i)
            {
                _initializeControllers[i].Initialization();
            }
        }

        public void Execute(float deltaTime)
        {
            for (var i = 0; i < _executeControllers.Count; ++i)
            {
                _executeControllers[i].Execute(deltaTime);
            }
        }

        public void FixedExecute(float deltaTime)
        {
            for (var i = 0; i < _fixedControllers.Count; ++i)
            {
                _fixedControllers[i].FixedExecute(deltaTime);
            }
        }


        public void LateExecute(float deltaTime)
        {
            for (var i = 0; i < _lateControllers.Count; ++i)
            {
                _lateControllers[i].LateExecute(deltaTime);
            }
        }

        public void CleanUp()
        {
            for (var i = 0; i < _cleanupControllers.Count; ++i)
            {
                _cleanupControllers[i].CleanUp();
            }
        }
    }
}


