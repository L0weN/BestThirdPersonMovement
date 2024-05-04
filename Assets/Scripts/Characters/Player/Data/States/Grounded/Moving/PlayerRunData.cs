using System;
using UnityEngine;

namespace Mert.MovementSystem
{
    [Serializable]
    public class PlayerRunData
    {
        [field: SerializeField][field: Range(1f, 2f)] public float SpeedModifier { get; private set; } = 1f;
    }
}
