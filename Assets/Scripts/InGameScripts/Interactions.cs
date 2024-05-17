using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().material.color = Color.gray;
        GlobalManager.StartInteraccion();

    }
    private void OnTriggerExit(Collider other)
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
