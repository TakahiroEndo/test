namespace Trigger.MonoBehaviour
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    public class OnParticleCollisionTrigger : MonoBehaviour
    {
        [Serializable]
        public class OnParticleCollisionEvent : UnityEvent<GameObject, GameObject> { }
        public OnParticleCollisionEvent onTrigger = new OnParticleCollisionEvent();

        void OnParticleCollision(GameObject other)
        {
            onTrigger.Invoke(gameObject, other);
        }

    }
}