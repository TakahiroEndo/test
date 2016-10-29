namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnAnimatorMoveTrigger : MonoBehaviour
    {
        [Serializable]
        public class FixedUpdateEvent : UnityEvent<GameObject> { }
        public FixedUpdateEvent onTrigger = new FixedUpdateEvent();

        void OnAnimatorMove()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}