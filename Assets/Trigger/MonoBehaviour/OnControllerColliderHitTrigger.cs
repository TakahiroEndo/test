namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnControllerColliderHitTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnControllerColliderHitEvent : UnityEvent<GameObject, ControllerColliderHit> { }
        public OnControllerColliderHitEvent onTrigger = new OnControllerColliderHitEvent();

        void OnControllerColliderHit(ControllerColliderHit hit)
        {
            onTrigger.Invoke(gameObject, hit);
        }

    }
}