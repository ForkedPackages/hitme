using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
     float speedtemp;
     public GameObject hitCharacter;
     public GameObject previousCharecter;
     public GameObject[] Character;
     public GameObject choosedcharacter;
     public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
     speedtemp = RotationSpeed;
     choosedcharacter = Character[Random.Range(0,Character.Length - 1)];
     previousCharecter = choosedcharacter;
    }

    // Update is called once per frame
    void Update()
    {
      rotatePlate();    
      Raycast();
    }
    
    void rotatePlate()
    {
        transform.Rotate(0,10 * RotationSpeed * Time.deltaTime,0);
    }

    void Raycast()
    {
        RaycastHit hit;

      if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
          if(hit.collider.GetInstanceID() == choosedcharacter.GetComponent<Collider>().GetInstanceID())
          {

              RotationSpeed = 0;

          }        
            
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

        }
        
    }
    
    public void RotateIncrease()
    {
       RotationSpeed = speedtemp + 5;
       speedtemp = RotationSpeed;
    }
    public void Randomcharacter()
    {

        choosedcharacter = Character[Random.Range(0,Character.Length - 1)];
        if(choosedcharacter == previousCharecter){

        choosedcharacter = Character[Random.Range(0,Character.Length - 1)];
         
         
        }

    }
    
}
