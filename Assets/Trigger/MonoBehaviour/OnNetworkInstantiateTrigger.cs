namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnNetworkInstantiateTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnNetworkInstantiateEvent : UnityEvent<GameObject, NetworkMessageInfo> { }
        public OnNetworkInstantiateEvent onTrigger = new OnNetworkInstantiateEvent();

        void OnNetworkInstantiate(NetworkMessageInfo info)
        {
            onTrigger.Invoke(gameObject, info);
        }

    }
}