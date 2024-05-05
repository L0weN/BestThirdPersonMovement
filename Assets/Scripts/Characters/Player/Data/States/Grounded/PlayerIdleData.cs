using System;
using System.Collections.Generic;
using UnityEngine;

namespace Mert.MovementSystem
{
    [Serializable]
    public class PlayerIdleData
    {
        [field: SerializeField] public List<PlayerCameraRecenteringData> BackwardsCameraRecenteringData { get; private set; }
    }
}
