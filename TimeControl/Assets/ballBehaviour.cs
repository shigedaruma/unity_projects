using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 10f;
    private int switching = 1;
    float playerTimeScale = 1.0f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (switching == 1)
        {
            transform.position += transform.forward * speed * Time.deltaTime * playerTimeScale;
        }
        if (switching == -1)
        {
            transform.position -= transform.forward * speed * Time.deltaTime * playerTimeScale;

        }

        if (Input.GetKey(KeyCode.A))
        {
            Time.timeScale = 0.1f;
            playerTimeScale = 10f;
            GetComponent<TrailRenderer>().emitting = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Time.timeScale = 1f;
            playerTimeScale = 1f;
            GetComponent<TrailRenderer>().emitting = false;

        }
        if (Input.GetKey(KeyCode.D))
        {
            Time.timeScale = 1f;
            playerTimeScale = 10f;
            GetComponent<TrailRenderer>().emitting = true;

        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name != "Floor")
        {
            switching *= -1;
        }
        Debug.Log("ball:"+collision.gameObject.name);
    }
}

