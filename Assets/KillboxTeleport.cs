using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillboxTeleport : MonoBehaviour
{
    public CharacterController player;
    public Transform checkpoint;
    public Vector3 resetPoint;
    public Vector3 currentPos;
    Vector3 posToTeleport;

    private void OnTriggerEnter(Collider other)
    {
        resetPoint = checkpoint.transform.position;
        posToTeleport = resetPoint - player.transform.position;
        player.Move(posToTeleport);
    }
}
