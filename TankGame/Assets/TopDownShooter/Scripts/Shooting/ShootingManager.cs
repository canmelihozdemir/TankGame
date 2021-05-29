using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame.Shooting
{
    public class ShootingManager : MonoBehaviour
    {
        public void Shoot(Vector3 from,Vector3 direction)
        {
            RaycastHit hit;
            bool rayHit= Physics.Raycast(from, direction, out hit, Mathf.Infinity);
            Debug.DrawLine(from,from+direction*10,Color.yellow,5);
            if (rayHit)
            {
                Debug.Log(hit.collider.name);
            }
        }
    }
}

