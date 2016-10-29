namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnTriggerEnterTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnTriggerEnterEvent : UnityEvent<GameObject, Collider> { }
        public OnTriggerEnterEvent onTrigger = new OnTriggerEnterEvent();

        void OnTriggerEnter(Collider other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}