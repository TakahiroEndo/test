namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnPreCullTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnPreCullEvent : UnityEvent<GameObject> { }
        public OnPreCullEvent onTrigger = new OnPreCullEvent();

        void OnPreCull()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}