namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnMouseOverTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnMouseOverEvent : UnityEvent<GameObject> { }
        public OnMouseOverEvent onTrigger = new OnMouseOverEvent();

        void OnMouseOver()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}