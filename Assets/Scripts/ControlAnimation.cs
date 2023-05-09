using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimation : MonoBehaviour
{
    private Animator mAnim;

    // Start is called before the first frame update
    void Start()
    {
        mAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            mAnim.SetTrigger("TR_Animate");
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            mAnim.SetTrigger("TR_Stop");
        }
    }
}
