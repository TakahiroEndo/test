namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnCollisionEnter2DTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnCollisionEnter2DEvent : UnityEvent<GameObject, Collision2D> { }
        public OnCollisionEnter2DEvent onTrigger = new OnCollisionEnter2DEvent();

        void OnCollisionEnter2D(Collision2D other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}