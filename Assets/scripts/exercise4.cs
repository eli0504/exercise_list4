using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise4 : MonoBehaviour
{
    public GameObject[] elementPrefabs; //ARRAY 
    public string elementIndex;

    public void SpawnRandomElement()  //function that makes a random element appear
    {
        elementIndex = Random.Range(0, elementPrefabs.Length);  //we generate random index
    }
}
