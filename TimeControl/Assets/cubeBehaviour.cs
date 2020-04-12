using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 10f;
    private int switching = 1;
    //float realDeltaTime;
    //float lastRealTime;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //  realDeltaTime = Time.realtimeSinceStartup - lastRealTime;
        if (switching == 1)
        {
            transform.position += transform.forward * speed * Time.deltaTime;// realDeltaTime;
        }
        if (switching == -1)
        {
            transform.position -= transform.forward * speed * Time.deltaTime; // realDeltaTime;
        }
        if (Time.timeScale == 0.1f)
        {
            GetComponent<TrailRenderer>().emitting = true;
        }
        else
        {
            GetComponent<TrailRenderer>().emitting = false;

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name != "Floor")
        {
            switching *= -1;
        }
        Debug.Log("ball:" + collision.gameObject.name);
    }
}

