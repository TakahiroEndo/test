namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnValidateTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnValidateEvent : UnityEvent<GameObject> { }
        public OnValidateEvent onTrigger = new OnValidateEvent();

        void OnValidate()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}