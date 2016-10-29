namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnPreRenderTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnPreRenderEvent : UnityEvent<GameObject> { }
        public OnPreRenderEvent onTrigger = new OnPreRenderEvent();

        void OnPreRender()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}