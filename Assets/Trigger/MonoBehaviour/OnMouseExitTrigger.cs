namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnMouseExitTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnMouseExitEvent : UnityEvent<GameObject> { }
        public OnMouseExitEvent onTrigger = new OnMouseExitEvent();

        void OnMouseExit()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}