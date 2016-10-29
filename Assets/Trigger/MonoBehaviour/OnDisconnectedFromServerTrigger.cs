namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnDisconnectedFromServerTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnDisconnectedFromServerEvent : UnityEvent<GameObject, NetworkDisconnection> { }
        public OnDisconnectedFromServerEvent onTrigger = new OnDisconnectedFromServerEvent();

        void OnDisconnectedFromServer(NetworkDisconnection info)
        {
            onTrigger.Invoke(gameObject, info);
        }

    }
}