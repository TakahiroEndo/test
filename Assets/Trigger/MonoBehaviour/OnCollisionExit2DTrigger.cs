namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnCollisionExit2Digger : MonoBehaviour
    {
        [Serializable]
        public class OnCollisionExit2DEvent : UnityEvent<GameObject, Collision2D> { }
        public OnCollisionExit2DEvent onTrigger = new OnCollisionExit2DEvent();

        void OnCollisionExit2D(Collision2D other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}