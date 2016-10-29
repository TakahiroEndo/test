namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnMouseUpTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnMouseUpEvent : UnityEvent<GameObject> { }
        public OnMouseUpEvent onTrigger = new OnMouseUpEvent();

        void OnMouseUp()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}