using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_button : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void boutton_touch()
    {
        animator.SetTrigger("Trigger");
    }
}
