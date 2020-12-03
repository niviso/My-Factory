using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SunRotation : MonoBehaviour
{
  public float dayLength;
  public float rotationSpeed;
void Update () {

     rotationSpeed = Time.deltaTime / dayLength;

     transform.Rotate(0, rotationSpeed ,0);

}
}
