using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPressForFun : MonoBehaviour
{
    public Animator animator;
    public void HighlightPlay()
    {
        animator.Play("ButtonPress");
    }
}
