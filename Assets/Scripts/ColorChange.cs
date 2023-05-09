using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField]
    public ColorChange boxColor;
    private MeshRenderer shapeMesh;
    
    // Start is called before the first frame update
    void Start()
    {
        shapeMesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        shapeMesh.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
