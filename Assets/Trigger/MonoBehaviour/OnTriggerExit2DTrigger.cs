namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnTriggerExit2DTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnTriggerExit2DEvent : UnityEvent<GameObject, Collider2D> { }
        public OnTriggerExit2DEvent onTrigger = new OnTriggerExit2DEvent();

        void OnTriggerExit2D(Collider2D other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}