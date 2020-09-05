using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatScript : MonoBehaviour
{

    public GameObject Plate;
    public GameObject GameManager;
    // Start is called before the first frame update
    void Start()
    {
    
     Plate = GameObject.Find("Plate");
     GameManager = GameObject.Find("FoodManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider character)
    {
        if(character.tag == "character")
        {
            Plate.GetComponent<Plate>().Randomcharacter();
            Plate.GetComponent<Plate>().RotateIncrease();
            GameManager.GetComponent<GameManager>().clonefood();

            Destroy(gameObject.GetComponent<eatScript>());

            Destroy(this.gameObject);
        }
    }
}
