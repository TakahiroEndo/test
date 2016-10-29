namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnTransformParentChangedTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnTransformParentChangedEvent : UnityEvent<GameObject> { }
        public OnTransformParentChangedEvent onTrigger = new OnTransformParentChangedEvent();

        void OnTransformParentChanged()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}