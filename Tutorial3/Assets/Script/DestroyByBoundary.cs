using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    private void OnTriggerExit(Collider other) //anything that leave the box get destroyed
    {
        Destroy(other.gameObject);
    }
}
