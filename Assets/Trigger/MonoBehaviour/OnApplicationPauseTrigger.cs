namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnApplicationPauseTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnApplicationPauseEvent : UnityEvent<GameObject, bool> { }
        public OnApplicationPauseEvent onTrigger = new OnApplicationPauseEvent();

        void OnApplicationPause(bool pauseStatus)
        {
            onTrigger.Invoke(gameObject, pauseStatus);
        }

    }
}