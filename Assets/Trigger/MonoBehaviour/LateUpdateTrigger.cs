namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class LateUpdateTrigger : MonoBehaviour
    {
        [Serializable]
        public class LateUpdateEvent : UnityEvent<GameObject> { }
        public LateUpdateEvent onTrigger = new LateUpdateEvent();

        void LateUpdate()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}