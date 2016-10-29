namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnPostRenderTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnPostRenderEvent : UnityEvent<GameObject> { }
        public OnPostRenderEvent onTrigger = new OnPostRenderEvent();

        void OnPostRender()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}