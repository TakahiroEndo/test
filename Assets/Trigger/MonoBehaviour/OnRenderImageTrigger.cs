namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnRenderImageTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnRenderImageEvent : UnityEvent<GameObject> { }
        public OnRenderImageEvent onTrigger = new OnRenderImageEvent();

        void OnRenderImage()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}