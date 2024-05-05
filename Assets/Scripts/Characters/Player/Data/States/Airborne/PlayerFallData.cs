using System;
using UnityEngine;

namespace Mert.MovementSystem
{
    [Serializable]
    public class PlayerFallData
    {
        [field: SerializeField][field: Range(1f, 15f)] public float FallSpeedLimit { get; private set; } = 15f;
        [field: SerializeField][field: Range(0f, 100f)] public float MinDistanceToBeConsideredHardFall { get; private set; } = 3f;

    }
}
