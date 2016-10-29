namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnJointBreakTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnJointBreakEvent : UnityEvent<GameObject, float> { }
        public OnJointBreakEvent onTrigger = new OnJointBreakEvent();

        void OnJointBreak(float breakForce)
        {
            onTrigger.Invoke(gameObject, breakForce);
        }

    }
}