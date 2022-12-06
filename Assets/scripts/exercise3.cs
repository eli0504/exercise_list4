using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise3 : MonoBehaviour
{
  public Vector3 limit(int lowerLimit, int upperLimit) 
    { 
        //Random.Range generates a random number between a lower limit and the uppewr limit
        int x = Random.Range(lowerLimit, upperLimit);
        int y = Random.Range(lowerLimit, upperLimit);
        int z = Random.Range(lowerLimit, upperLimit);
        return new Vector3(x, y, z); 
    }
}
