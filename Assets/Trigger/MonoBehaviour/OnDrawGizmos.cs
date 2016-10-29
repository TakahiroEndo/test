namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnDrawGizmosTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnDrawGizmosEvent : UnityEvent<GameObject> { }
        public OnDrawGizmosEvent onTrigger = new OnDrawGizmosEvent();

        void OnDrawGizmos()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}