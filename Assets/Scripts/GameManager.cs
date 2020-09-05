using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   public GameObject Plate;
    GameObject foodtemp;
    public GameObject[] food;
    // Start is called before the first frame update
    void Start()
    {
        
        Plate = GameObject.Find("Plate");
        foodtemp = Instantiate(food[Random.Range(0,food.Length)],new Vector3(Plate.transform.position.x,Plate.transform.position.y + 0.5f,Plate.transform.position.z),Quaternion.identity); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clonefood()
    {
            foodtemp = Instantiate(food[Random.Range(0,food.Length)],new Vector3(Plate.transform.position.x,Plate.transform.position.y + 0.5f,Plate.transform.position.z),Quaternion.identity); 

    }
}

