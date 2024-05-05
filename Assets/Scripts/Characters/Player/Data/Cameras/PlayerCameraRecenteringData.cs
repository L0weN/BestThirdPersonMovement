using System;
using UnityEngine;

namespace Mert.MovementSystem
{
    [Serializable]
    public class PlayerCameraRecenteringData
    {
        [field: SerializeField][Range(0f, 360f)] public float MinAngle { get; private set; }
        [field: SerializeField][Range(0f, 360f)] public float MaxAngle { get; private set; }
        [field: SerializeField][Range(-1f, 20f)] public float WaitTime { get; private set; }
        [field: SerializeField][Range(-1f, 20f)] public float RecenteringTime { get; private set; }

        public bool IsWithinRange(float angle)
        {
            return angle >= MinAngle && angle <= MaxAngle;
        }
    }
}
