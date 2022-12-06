using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise5 : MonoBehaviour
{
    public bool isInBounds(int upperLimit, int lowerLimit, int position)
    {
        if (upperLimit >= position && lowerLimit <= position) //calculate the position (in bounds or out of bounds
        {
            return true; //returns true if i'm not out of bounds
        }
        else
        {
            return false; //returns false if i am out of bounds
        }
    }

}
