using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Health NPC
    public int health = 1;
    //Speed NPC
    public float speed = 0.2f;
    //Name NPC
    public string name = "Man";
    //Level
    public int level = 1;

    // Start is called before the first frame update
    void Start()
    { 
        health += level;
        print("Твое состояние здоровья: "+health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z+=speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
