namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnBecameVisibleTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnBecameVisibleEvent : UnityEvent<GameObject> { }
        public OnBecameVisibleEvent onTrigger = new OnBecameVisibleEvent();

        void OnBecameVisible()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}