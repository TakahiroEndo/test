namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class FixedUpdateTrigger : MonoBehaviour
    {
        [Serializable]
        public class FixedUpdateEvent : UnityEvent<GameObject> { }
        public FixedUpdateEvent onTrigger = new FixedUpdateEvent();

        void FixedUpdate()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}