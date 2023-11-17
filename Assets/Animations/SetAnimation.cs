using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimation : MonoBehaviour
{
    public RuntimeAnimatorController animator;
    public int dance;

    void Start()
    {
        Animator a = gameObject.AddComponent<Animator>();
        a.runtimeAnimatorController = Instantiate(animator);
        a.SetInteger("Dance", dance);
    }
}
