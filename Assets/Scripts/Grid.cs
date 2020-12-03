using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public int width;
    public int height;
    public int size;
    // Start is called before the first frame update
    void Start()
    {
      for(int x = 0;x!=width;x++){
        for(int y = 0;y!=height;y++){
          GameObject objToSpawn = GameObject.CreatePrimitive(PrimitiveType.Cube);

          //Add size and postion
          objToSpawn.transform.localScale =  new Vector3(size,1,size);
          objToSpawn.transform.position = new Vector3(x*size,0,y*size);
          objToSpawn.name = x+","+y;
          objToSpawn.tag = "Floor";
          //Add Components
          objToSpawn.AddComponent<BoxCollider>();
        }
      }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
