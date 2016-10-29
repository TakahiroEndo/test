namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnMasterServerEventTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnMasterServerEventEvent : UnityEvent<GameObject, MasterServerEvent> { }
        public OnMasterServerEventEvent onTrigger = new OnMasterServerEventEvent();

        void OnMasterServerEvent(MasterServerEvent msEvent)
        {
            onTrigger.Invoke(gameObject, msEvent);
        }

    }
}