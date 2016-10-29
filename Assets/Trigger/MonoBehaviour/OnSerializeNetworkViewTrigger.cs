namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnSerializeNetworkViewTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnSerializeNetworkViewEvent : UnityEvent<GameObject, BitStream, NetworkMessageInfo> { }
        public OnSerializeNetworkViewEvent onTrigger = new OnSerializeNetworkViewEvent();

        void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
        {
            onTrigger.Invoke(gameObject, stream, info);
        }

    }
}