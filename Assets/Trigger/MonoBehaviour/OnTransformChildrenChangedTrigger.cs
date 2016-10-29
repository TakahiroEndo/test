namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnTransformChildrenChangedTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnTransformChildrenChangedEvent : UnityEvent<GameObject> { }
        public OnTransformChildrenChangedEvent onTrigger = new OnTransformChildrenChangedEvent();

        void OnTransformChildrenChanged()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}