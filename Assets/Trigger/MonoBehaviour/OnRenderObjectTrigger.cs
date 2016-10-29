namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnRenderObjectTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnRenderObjectEvent : UnityEvent<GameObject> { }
        public OnRenderObjectEvent onTrigger = new OnRenderObjectEvent();

        void OnRenderObject()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}