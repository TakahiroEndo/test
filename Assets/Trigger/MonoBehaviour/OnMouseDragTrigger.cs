namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnMouseDragTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnMouseDragEvent : UnityEvent<GameObject> { }
        public OnMouseDragEvent onTrigger = new OnMouseDragEvent();

        void OnMouseDrag()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}