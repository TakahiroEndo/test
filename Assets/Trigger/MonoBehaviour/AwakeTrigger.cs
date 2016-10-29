namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class AwakeTrigger : MonoBehaviour
    {
        [Serializable]
        public class AwakeEvent : UnityEvent<GameObject> { }
        public AwakeEvent onTrigger = new AwakeEvent();

        void Awake()
        {
            onTrigger.Invoke(gameObject);
        }

    }

}