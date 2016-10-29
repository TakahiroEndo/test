namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnJointBreak2DTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnJointBreak2DEvent : UnityEvent<GameObject, Joint2D> { }
        public OnJointBreak2DEvent onTrigger = new OnJointBreak2DEvent();

        void OnJointBreak2D(Joint2D brokenJoint)
        {
            onTrigger.Invoke(gameObject, brokenJoint);
        }

    }
}