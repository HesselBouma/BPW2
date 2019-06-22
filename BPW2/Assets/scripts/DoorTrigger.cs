using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    [SerializeField]
    GameObject door;

    [SerializeField]
    GameObject character;


    void OnTriggerEnter(Collider col)
    {
        Destroy(door);
        Destroy(character);

    }


}
