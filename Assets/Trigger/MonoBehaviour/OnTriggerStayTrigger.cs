namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnTriggerStayTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnTriggerStayEvent : UnityEvent<GameObject, Collider> { }
        public OnTriggerStayEvent onTrigger = new OnTriggerStayEvent();

        void OnTriggerStay(Collider other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}