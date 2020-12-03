using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour
{
  public float spawnsPerMinute;
  public GameObject spawnObj;
  public float cd;
  void Start () {
  	cd = 60 / spawnsPerMinute;
  }

  void Update () {

  if(cd <=0){
  	Instantiate(spawnObj,transform.position, Quaternion.identity);
  	cd = 60/ spawnsPerMinute;
  } else
  	cd -= Time.deltaTime;


  }
}
