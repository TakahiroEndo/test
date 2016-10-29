namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnFailedToConnectTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnFailedToConnectEvent : UnityEvent<GameObject, NetworkConnectionError> { }
        public OnFailedToConnectEvent onTrigger = new OnFailedToConnectEvent();

        void OnFailedToConnect(NetworkConnectionError error)
        {
            onTrigger.Invoke(gameObject, error);
        }

    }
}