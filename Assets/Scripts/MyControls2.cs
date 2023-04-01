using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XRContent.Interaction;

public class MyControls2 : MonoBehaviour
{
    public GameObject bouncyBall;
    public GameObject spawnLoc;
    public GameObject myXRKnobContainer;
    public float theValue;
    public int myIntValue;



    public void SpawnKnobObjs()
    {
        //Determine the raw value of the knob's "value"
        theValue = myXRKnobContainer.GetComponent<XRKnob>().Value;

        if(theValue == 0)
        {
            myIntValue = 0;
        }

        else if(theValue == 0.25f)
        {
            myIntValue = 1;
        }

        else if (theValue == 0.50f)
        {
            myIntValue = 2;
        }

        else if (theValue == 0.75f)
        {
            myIntValue = 3;
        }

        else if (theValue == 1.0f)
        {
            myIntValue = 4;
        }
        //Debug.Log("myIntValue translated to " + myIntValue + " from the raw value of: " + theValue);

        StartCoroutine(SpawnAway2());
    }

    IEnumerator SpawnAway2()
    {
        Debug.Log("Ran coroutine with a myIntValue of: " + myIntValue);

        for(int i = myIntValue; i > 0; i--)
        {
            //Spawn Bouncy Balls w/ delay
            Instantiate(bouncyBall, spawnLoc.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            Debug.Log("Spawns Left: " + myIntValue);
        }
        //
    }


    public void Spawn1Ball()
    {
        Instantiate(bouncyBall, spawnLoc.transform.position, Quaternion.identity);
    }

    
}
