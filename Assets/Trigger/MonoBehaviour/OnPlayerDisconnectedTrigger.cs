namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnPlayerDisconnectedTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnPlayerDisconnectedEvent : UnityEvent<GameObject, NetworkPlayer> { }
        public OnPlayerDisconnectedEvent onTrigger = new OnPlayerDisconnectedEvent();

        void OnPlayerDisconnected(NetworkPlayer player)
        {
            onTrigger.Invoke(gameObject, player);
        }

    }
}