//using JoostenProductions;
using Tool;
using UnityEngine;

namespace Game.InputLogic
{
    internal class GyroscopeInputView : BaseInputView
    {
        [SerializeField] private float _inputMultiplier = 10;

        public override void Init(
            SubscriptionProperty<float> leftMove,
            SubscriptionProperty<float> rightMove,
            float speed)
        {
            base.Init(leftMove, rightMove, speed);
            Input.gyro.enabled = true;
        }


        //private void Start() =>
            //UpdateManager.SubscribeToUpdate(Move);

        //private void OnDestroy() =>
            //UpdateManager.UnsubscribeFromUpdate(Move);


        private void Move()
        {
            if (!SystemInfo.supportsGyroscope)
                return;

            Quaternion quaternion = Input.gyro.attitude;
            quaternion.Normalize();

            float offset = quaternion.x + quaternion.y;
            float moveValue = _speed * _inputMultiplier * Time.deltaTime * offset;

            float abs = Mathf.Abs(moveValue);
            float sign = Mathf.Sign(moveValue);

            if (sign > 0)
                OnRightMove(abs);
            else
                OnLeftMove(abs);
        }
    }
}
