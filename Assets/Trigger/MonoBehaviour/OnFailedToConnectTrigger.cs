namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnFailedToConnectToMasterServerTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnFailedToConnectToMasterServerEvent : UnityEvent<GameObject, NetworkConnectionError> { }
        public OnFailedToConnectToMasterServerEvent onTrigger = new OnFailedToConnectToMasterServerEvent();

        void OnFailedToConnectToMasterServer(NetworkConnectionError error)
        {
            onTrigger.Invoke(gameObject, error);
        }

    }
}