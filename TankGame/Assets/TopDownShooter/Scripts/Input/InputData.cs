using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.PlayerInput
{
    [CreateAssetMenu(menuName = "TankGame/UserInput/UserInput Settings", fileName = "UserInputSettings")]
    public class InputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;
    }

}
