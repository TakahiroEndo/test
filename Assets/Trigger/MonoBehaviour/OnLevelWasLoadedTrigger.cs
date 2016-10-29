namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnLevelWasLoadedTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnLevelWasLoadedEvent : UnityEvent<GameObject, int> { }
        public OnLevelWasLoadedEvent onTrigger = new OnLevelWasLoadedEvent();

        void OnLevelWasLoaded(int level)
        {
            onTrigger.Invoke(gameObject, level);
        }

    }
}