using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mul : MonoBehaviour
{
    void Start()
    {
        for(int Num=1 ; Num<=10 ; Num++)
        {
            Debug.Log("5 x "+ Num + " = " + Multiply(5,Num));
        }
    }

    int Multiply (int numberOne, int numberTow)
    {
        return numberOne*numberTow;
    }
}
