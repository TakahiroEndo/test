namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnPlayerConnectedTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnPlayerConnectedEvent : UnityEvent<GameObject, NetworkPlayer> { }
        public OnPlayerConnectedEvent onTrigger = new OnPlayerConnectedEvent();

        void OnPlayerConnected(NetworkPlayer player)
        {
            onTrigger.Invoke(gameObject, player);
        }

    }
}