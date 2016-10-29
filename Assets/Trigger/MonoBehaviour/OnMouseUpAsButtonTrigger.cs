namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnMouseUpAsButtonTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnMouseUpAsButtonEvent : UnityEvent<GameObject> { }
        public OnMouseUpAsButtonEvent onTrigger = new OnMouseUpAsButtonEvent();

        void OnMouseUpAsButton()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}