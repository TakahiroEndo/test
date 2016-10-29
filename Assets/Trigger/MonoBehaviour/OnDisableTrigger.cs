namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnDisableTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnDisableEvent : UnityEvent<GameObject> { }
        public OnDisableEvent onTrigger = new OnDisableEvent();

        void OnDisable()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}