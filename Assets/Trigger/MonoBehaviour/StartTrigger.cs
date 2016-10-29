namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class StartTrigger : MonoBehaviour
    {
        [Serializable]
        public class StartEvent : UnityEvent<GameObject> { }
        public StartEvent onTrigger = new StartEvent();

        void Start()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}