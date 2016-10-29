namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class UpdateTrigger : MonoBehaviour
    {
        [Serializable]
        public class UpdateEvent : UnityEvent<GameObject> { }
        public UpdateEvent onTrigger = new UpdateEvent();

        void Update()
        {
            onTrigger.Invoke(gameObject);
        }

    }
}