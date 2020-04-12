using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masamoveBehaviour : MonoBehaviour
{
    public float speed = 5.0f;
    
    

    public Animator anim;
    public Rigidbody rb;
    private bool isRun=false;

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

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRun = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isRun = false;
        }
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            
            if (isRun==true){ 
                anim.SetBool("Run", true);

            }
            else
            {
                anim.SetBool("Walk", true);
                anim.SetBool("Run", false);

            }
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

}
