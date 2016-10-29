namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnWillRenderObjectTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnWillRenderObjectEvent : UnityEvent<GameObject> { }
        public OnWillRenderObjectEvent onTrigger = new OnWillRenderObjectEvent();

        void OnWillRenderObject()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}