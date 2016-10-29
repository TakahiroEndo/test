namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnGUITrigger : MonoBehaviour
    {
        [Serializable]
        public class OnGUIEvent : UnityEvent<GameObject> { }
        public OnGUIEvent onTrigger = new OnGUIEvent();

        void OnGUI()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}