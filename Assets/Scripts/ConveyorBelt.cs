
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
  public float speed;
  public Vector3 direction;
  public List<GameObject> onBelt;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame


  // When something collides with the belt
  private void OnCollisionStay(Collision collision)
  {
      collision.gameObject.GetComponent<Rigidbody>().velocity = speed * direction * Time.deltaTime;
  }

  // When something leaves the belt

}
