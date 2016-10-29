namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnConnectedToServerTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnConnectedToServerEvent : UnityEvent<GameObject> { }
        public OnConnectedToServerEvent onTrigger = new OnConnectedToServerEvent();

        void OnConnectedToServer()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}