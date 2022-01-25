using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public CharacterController player;
    public Vector3 resetPoint;
    public Vector3 currentPos;
    Vector3 posToTeleport;

    // Start is called before the first frame update
    void Start()
    {
        resetPoint = new Vector3(0.0f, 1.5f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Reseting player");
            posToTeleport = resetPoint - player.transform.position;
            player.Move(posToTeleport);
        }
    }
}
