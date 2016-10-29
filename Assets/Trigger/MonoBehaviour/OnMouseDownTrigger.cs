namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnMouseDownTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnMouseDownEvent : UnityEvent<GameObject> { }
        public OnMouseDownEvent onTrigger = new OnMouseDownEvent();

        void OnMouseDown()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}