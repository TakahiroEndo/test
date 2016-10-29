namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnTriggerEnter2DTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnTriggerEnter2DEvent : UnityEvent<GameObject, Collider2D> { }
        public OnTriggerEnter2DEvent onTrigger = new OnTriggerEnter2DEvent();

        void OnTriggerEnter2D(Collider2D other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}