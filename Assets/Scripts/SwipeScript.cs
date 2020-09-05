using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeScript : MonoBehaviour {
    Vector3 stpos;
	Vector3 endpos;
	GameObject food;	
	void Start()
	{
		
	
	}

	void Update () {
    RaycastHit hit;
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	Debug.DrawRay(ray.origin,ray.direction, Color.yellow);
if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity)){

	if(Input.GetMouseButtonDown(0))
	{
     stpos.y = Input.mousePosition.y;
	 food = hit.collider.gameObject;
	}
	
	}
	endpos.y = Input.mousePosition.y;
	if(Input.GetMouseButtonUp(0))
	{

	 food.GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(ray.direction.x,0,ray.direction.z)* Mathf.Abs((stpos.y - endpos.y))  ,new Vector3(ray.direction.x,0,ray.direction.z*10));
	}

	}

}