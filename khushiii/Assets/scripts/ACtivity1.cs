using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACtivity1 : MonoBehaviour
{
    public string myName= "khushi";
    public string favGame= "TLOU SERIES";
    public int hoursPlayed= 750;
    public float amount = 200f;

    void Start()
    {
        Debug.Log("My name is " +  myName + " and favourite game is " + favGame + " I have played it for " + hoursPlayed + " it cost me " + amount + " therefore my value of dollar per hour is " + amount/hoursPlayed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
