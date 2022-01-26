using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public CharacterController player;
    public Transform checkpoint;
    public Vector3 resetPoint;
    public Vector3 currentPos;
    Vector3 posToTeleport;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Reseting player");
            resetPoint = checkpoint.transform.position;
            posToTeleport = resetPoint - player.transform.position;
            player.Move(posToTeleport);
        }
    }
}
