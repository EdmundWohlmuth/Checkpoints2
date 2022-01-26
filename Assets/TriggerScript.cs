using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public bool deleteThis = true;
    public Transform resetPoint;
    public Transform checkpoint1;
    public Transform checkpoint2;
    int checkpointIncriment = 0;

    private void OnTriggerEnter(Collider other)
    {
        checkpointIncriment++;
        if (checkpointIncriment == 1)
        {
            resetPoint.transform.position = checkpoint1.transform.position;
        }
        else if (checkpointIncriment == 2)
        {
            resetPoint.transform.position = checkpoint2.transform.position;
        }
        

        if (deleteThis == true)
        {
            Destroy(this.gameObject);
        }
    }
}
