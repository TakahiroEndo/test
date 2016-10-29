namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnServerInitializedTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnServerInitializedEvent : UnityEvent<GameObject> { }
        public OnServerInitializedEvent onTrigger = new OnServerInitializedEvent();

        void OnServerInitialized()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}