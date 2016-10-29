namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnCollisionStay2DTigger : MonoBehaviour
    {
        [Serializable]
        public class OnCollisionStay2DEvent : UnityEvent<GameObject, Collision2D> { }
        public OnCollisionStay2DEvent onTrigger = new OnCollisionStay2DEvent();

        void OnCollisionStay2D(Collision2D other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}