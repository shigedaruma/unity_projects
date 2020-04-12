using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masamoveBehaviour : MonoBehaviour
{
    public float speed = 5.0f;

    

    public Animator anim;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject shadow = GameObject.Find("Shadow");
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        


    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            anim.SetBool("Walk", true);
            transform.rotation = Quaternion.LookRotation(transform.position +
            (Vector3.right * Input.GetAxisRaw("Horizontal")) +
            (Vector3.forward * Input.GetAxisRaw("Vertical"))
            - transform.position);
        }
        else
        {
            anim.SetBool("Walk", false);

        }

    }
    private void FixedUpdate()
    {


    }
}
