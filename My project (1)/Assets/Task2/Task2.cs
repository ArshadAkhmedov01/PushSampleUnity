using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    List<GameObject> objects;
    // Start is called before the first frame update
    void Start()
    {
        objects = GameObject.FindGameObjectsWithTag("Collectable").ToList();

        foreach (var item in objects)
        {
            item.gameObject.tag = "Collected";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
