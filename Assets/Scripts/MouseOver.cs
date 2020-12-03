using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour
{
  Ray ray;
RaycastHit hit;
public GameObject selectedGameObject;
public int EdgePadding = 20;
public int CameraMoveSpeed = 50;
public GameObject SpawnThis;
Color OriginalColor;
void Update()
{
    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    if (Input.GetKey(KeyCode.W)){
      transform.position = new Vector3(transform.position.x,transform.position.y,(transform.position.z + CameraMoveSpeed* Time.deltaTime));
    }

    if (Input.GetKey(KeyCode.S)){
      transform.position = new Vector3(transform.position.x,transform.position.y,(transform.position.z - CameraMoveSpeed* Time.deltaTime));
    }

    if (Input.GetKey(KeyCode.D)){
      transform.position = new Vector3((transform.position.x + CameraMoveSpeed* Time.deltaTime),transform.position.y,transform.position.z);
    }
    if (Input.GetKey(KeyCode.A)){
      transform.position = new Vector3((transform.position.x - CameraMoveSpeed* Time.deltaTime),transform.position.y,transform.position.z);
    }
    if(Input.GetAxis("Mouse ScrollWheel") > 0){
      transform.position = new Vector3(transform.position.x,(transform.position.y + 200 * Time.deltaTime) ,transform.position.z);
    }
    if(Input.GetAxis("Mouse ScrollWheel") < 0){
      transform.position = new Vector3(transform.position.x,(transform.position.y - 200 * Time.deltaTime) ,transform.position.z);
    }



    if(Physics.Raycast(ray, out hit))
    {
      if(hit.collider.gameObject.tag == "Floor"){
      hit.collider.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        if(selectedGameObject != hit.collider.gameObject){
          if(selectedGameObject){
            selectedGameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
          }
          selectedGameObject = hit.collider.gameObject;
        }
        if (Input.GetMouseButtonDown(0)){
              GameObject createdObj = Instantiate(SpawnThis,new Vector3(hit.collider.gameObject.transform.position.x,hit.collider.gameObject.transform.position.y+1,hit.collider.gameObject.transform.position.z),Quaternion.identity);
        }
      }
    } else {
      if(selectedGameObject){
        selectedGameObject.GetComponent<Collider>().gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
        selectedGameObject = null;
      }
    }
}
}
