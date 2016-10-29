namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnCollisionExitTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnCollisionExitEvent : UnityEvent<GameObject, Collision> { }
        public OnCollisionExitEvent onTrigger = new OnCollisionExitEvent();

        void OnCollisionExit(Collision other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}