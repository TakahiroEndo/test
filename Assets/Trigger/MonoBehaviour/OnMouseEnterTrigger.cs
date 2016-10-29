namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnMouseEnterTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnMouseEnterEvent : UnityEvent<GameObject> { }
        public OnMouseEnterEvent onTrigger = new OnMouseEnterEvent();

        void OnMouseEnter()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}