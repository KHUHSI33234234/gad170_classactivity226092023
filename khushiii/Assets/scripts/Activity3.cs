using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity3 : MonoBehaviour
{
    public int strength;
    public int agility;
    public int intelligence;
    public int statPool;

    // Start is called before the first frame update
    void Start()
    {
        statPool = 20; // set stat pool value

        //strength stat
        strength = Random.Range(0, statPool);
        statPool = statPool - strength;

        //agility stat
        agility = Random.Range(0, statPool);
        statPool = statPool - agility;

        //intelligence stat
        intelligence = Random.Range(0, statPool);
        statPool = statPool - intelligence;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //priniting
            Debug.Log("My stats are: ");
            Debug.Log("Strength =" + strength);
            Debug.Log("Agility =" + agility);
            Debug.Log("intelligence =" + intelligence);

        }

    }
}
