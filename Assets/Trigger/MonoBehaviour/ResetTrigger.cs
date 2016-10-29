namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class ResetTrigger : MonoBehaviour
    {
        [Serializable]
        public class ResetEvent : UnityEvent<GameObject> { }
        public ResetEvent onTrigger = new ResetEvent();

        void Reset()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}