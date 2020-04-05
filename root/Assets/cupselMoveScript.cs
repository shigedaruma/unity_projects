using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupselMoveScript : MonoBehaviour
{
    [SerializeField]
    private float speed=3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 V = this.transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            // V.x -= speed;
            // gameObject.transform.position = V;
            transform.position -= transform.right * speed * Time.deltaTime;


        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;

        }
    }
}
