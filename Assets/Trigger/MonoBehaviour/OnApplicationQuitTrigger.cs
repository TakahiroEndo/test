namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnApplicationQuitTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnApplicationQuitEvent : UnityEvent<GameObject> { }
        public OnApplicationQuitEvent onTrigger = new OnApplicationQuitEvent();

        void OnApplicationQuit()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}