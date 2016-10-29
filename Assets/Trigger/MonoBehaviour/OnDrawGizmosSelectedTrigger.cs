namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnDrawGizmosSelectedTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnDrawGizmosSelectedEvent : UnityEvent<GameObject> { }
        public OnDrawGizmosSelectedEvent onTrigger = new OnDrawGizmosSelectedEvent();

        void OnDrawGizmosSelected()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}