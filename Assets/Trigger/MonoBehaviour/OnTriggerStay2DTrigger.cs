namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnTriggerStay2DTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnTriggerStay2DEvent : UnityEvent<GameObject, Collider2D> { }
        public OnTriggerStay2DEvent onTrigger = new OnTriggerStay2DEvent();

        void OnTriggerStay2D(Collider2D other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}