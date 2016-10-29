namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnCollisionStayTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnCollisionStaytEvent : UnityEvent<GameObject, Collision> { }
        public OnCollisionStaytEvent onTrigger = new OnCollisionStaytEvent();

        void OnCollisionStay(Collision other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}