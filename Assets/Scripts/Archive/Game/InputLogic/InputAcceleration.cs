//using JoostenProductions;
using UnityEngine;

namespace Game.InputLogic
{
    internal class InputAcceleration : BaseInputView
    {
        [SerializeField] private float _inputMultiplier = 0.05f;


        //private void Start() =>
            //UpdateManager.SubscribeToUpdate(Move);

        //private void OnDestroy() =>
            //UpdateManager.UnsubscribeFromUpdate(Move);


        private void Move()
        {
            Vector3 direction = CalcDirection();
            float moveValue = _speed * _inputMultiplier * Time.deltaTime * direction.x;

            float abs = Mathf.Abs(moveValue);
            float sign = Mathf.Sign(moveValue);

            if (sign > 0)
                OnRightMove(abs);
            else
                OnLeftMove(abs);
        }

        private Vector3 CalcDirection()
        {
            const float normalizedMagnitude = 1;

            Vector3 direction = Vector3.zero;
            direction.x = -Input.acceleration.y;
            direction.z = Input.acceleration.x;

            if (direction.sqrMagnitude > normalizedMagnitude)
                direction.Normalize();

            return direction;
        }
    }
}
