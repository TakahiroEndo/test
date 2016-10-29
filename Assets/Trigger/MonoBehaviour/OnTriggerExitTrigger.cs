namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnTriggerExitTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnTriggerExitEvent : UnityEvent<GameObject, Collider> { }
        public OnTriggerExitEvent onTrigger = new OnTriggerExitEvent();

        void OnTriggerExit(Collider other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}