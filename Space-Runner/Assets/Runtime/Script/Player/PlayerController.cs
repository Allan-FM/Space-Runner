using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private float fowardSpeed = 5;
   private void Update()
   {
       Vector3 position = transform.position;

       position.z = ProcessFowardMovement();

       transform.position = position;
   }
   private float ProcessFowardMovement()
   {
       return transform.position.z + fowardSpeed * Time.deltaTime;
   }
}
