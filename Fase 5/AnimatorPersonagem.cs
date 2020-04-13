using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorPersonagem : MonoBehaviour
{
    private Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnimator.SetFloat("VSpeed", Input.GetAxis("Vertical"));
    }
}
