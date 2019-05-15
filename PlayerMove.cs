using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float PlayerMoveSpeed;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0 || Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * PlayerMoveSpeed * Time.deltaTime, 0f, 0f));
        }

        anim.SetFloat("PlayerMoveX", Input.GetAxisRaw("Horizontal")); 
    }
}
