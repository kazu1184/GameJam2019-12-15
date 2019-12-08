using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnime3 : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("New Bool", true);
            animator.SetBool("New Bool1", true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            animator.SetBool("New Bool2", true);
        }
    }
}
