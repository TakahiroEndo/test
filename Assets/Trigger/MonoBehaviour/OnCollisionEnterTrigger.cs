namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnCollisionEnterTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnCollisionEnterEvent : UnityEvent<GameObject, Collision> { }
        public OnCollisionEnterEvent onTrigger = new OnCollisionEnterEvent();

        void OnCollisionEnter(Collision other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}