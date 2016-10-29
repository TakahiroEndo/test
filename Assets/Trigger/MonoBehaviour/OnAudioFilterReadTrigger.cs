namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnAudioFilterReadTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnAudioFilterReadEvent : UnityEvent<GameObject, float[], int> { }
        public OnAudioFilterReadEvent onTrigger = new OnAudioFilterReadEvent();

        void OnAudioFilterRead(float[] data, int channels)
        {
            onTrigger.Invoke(gameObject, data, channels);
        }

    }
}