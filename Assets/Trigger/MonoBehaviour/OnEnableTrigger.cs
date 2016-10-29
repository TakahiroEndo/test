namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnEnableTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnEnableEvent : UnityEvent<GameObject> { }
        public OnEnableEvent onTrigger = new OnEnableEvent();

        void OnEnable()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}