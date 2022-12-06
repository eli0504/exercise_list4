using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise1 : MonoBehaviour
{
    public int totalMoney;
    
    public void moneyBox(int money)
    {
        totalMoney += money;   //the total value is modified by adding the money that is introduced
    }
}
