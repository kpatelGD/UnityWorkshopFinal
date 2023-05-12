using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColorChange : MonoBehaviour
{
    public Material platformMat;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
        Debug.Log("Collision started");
    }

    private void OnCollisionExit(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        Debug.Log("Collision ended");
    }
}
