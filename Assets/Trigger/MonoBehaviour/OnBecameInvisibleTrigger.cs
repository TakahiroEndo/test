namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnBecameInvisibleTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnBecameInvisibleEvent : UnityEvent<GameObject> { }
        public OnBecameInvisibleEvent onTrigger = new OnBecameInvisibleEvent();

        void OnBecameInvisible()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}