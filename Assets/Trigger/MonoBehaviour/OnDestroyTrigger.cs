namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnDestroyTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnDestroyEvent : UnityEvent<GameObject> { }
        public OnDestroyEvent onTrigger = new OnDestroyEvent();

        void OnDestroy()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}