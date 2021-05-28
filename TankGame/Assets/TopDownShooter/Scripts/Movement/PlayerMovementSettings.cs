using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.PlayerMovement
{
    [CreateAssetMenu(menuName = "TankGame/Player/Movement Settings", fileName = "PlayerMovementSettings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float HorizontalSpeed=5f;
        public float VerticalSpeed=5f;
    }

}
