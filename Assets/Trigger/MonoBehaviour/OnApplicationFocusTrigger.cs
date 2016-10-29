namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnApplicationFocusTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnApplicationFocusEvent : UnityEvent<GameObject, bool> { }
        public OnApplicationFocusEvent onTrigger = new OnApplicationFocusEvent();

        void OnApplicationFocus(bool focusStatus)
        {
            onTrigger.Invoke(gameObject, focusStatus);
        }

    }
}