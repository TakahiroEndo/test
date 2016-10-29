namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnAnimatorIKTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnAnimatorIKEvent : UnityEvent<GameObject, int> { }
        public OnAnimatorIKEvent onTrigger = new OnAnimatorIKEvent();

        void OnAnimatorIK(int layerIndex)
        {
            onTrigger.Invoke(gameObject, layerIndex);
        }

    }
}