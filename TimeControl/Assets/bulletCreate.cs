using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCreate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = (GameObject)Resources.Load("bullet");
        Instantiate(obj);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
