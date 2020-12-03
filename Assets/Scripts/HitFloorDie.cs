using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitFloorDie : MonoBehaviour
{
    public bool SelfDestruct = false;
    public float SelfDestructInSeconds = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(SelfDestruct){
        SelfDestructInSeconds -= Time.deltaTime;
        if(SelfDestructInSeconds <= 0){
          Destroy(gameObject);
        }
      }


    }

    private void OnCollisionEnter(Collision collision){
      if(collision.gameObject.tag == "Floor"){
        SelfDestruct = true;
      }
    }
}
