using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class masamoveBehaviour : MonoBehaviour
{
    public float speed = 0.01f;



    public Animator anim;
    public Rigidbody rb;
    private bool isRun=false;
    private float targetAngle;
    private float startAngle;
    private float startTime;
    private float turnTime =0.5f;

    //GameObject camtarget= GameObject.Find("cameraTarget");
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
        /*キャラクターのカメラターゲットの座標をキャラクターと合わせる
        Vector3 position = transform.position;
        camtarget.transform.position　= position;*/
        //シフトキーを押しているかどうか？走っているかどうかのフラグセット
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRun = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isRun = false;
        }
    /*
        
        //バイオハザード風の動き
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
    */
        //前後移動
        if (Input.GetButton("Vertical"))
        {
            
            if (isRun==true){ 
                anim.SetBool("Run", true);
            }
            else
            {
                anim.SetBool("Walk", true);
                anim.SetBool("Run", false);
            }
        }
        else
        {
            anim.SetBool("Walk", false);
        }
        //Quarternionをつかったローテート masa
        if (Input.GetKey(KeyCode.A))
        {
            // x軸を軸にして毎秒-2度、回転させるQuaternionを作成（変数をrotとする）
            Quaternion rot = Quaternion.AngleAxis(-2, Vector3.up);
            // 現在の自信の回転の情報を取得する。
            Quaternion q = this.transform.rotation;
            // 合成して、自身に設定
            this.transform.rotation = q * rot;
        } 
        if (Input.GetKey(KeyCode.D))
        {
            // x軸を軸にして毎秒2度、回転させるQuaternionを作成（変数をrotとする）
            Quaternion rot = Quaternion.AngleAxis(2, Vector3.up);
            // 現在の自信の回転の情報を取得する。
            Quaternion q = this.transform.rotation;
            // 合成して、自身に設定
            this.transform.rotation = q * rot;
        } 
    /* GetButtonをつかった前後移動バイオ風 アニメーションだけで移動
        
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
        */

        /* Transformをつかった前後移動        
        
        if (Input.GetKey(KeyCode.W)){
            transform.position+=transform.forward*speed*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)){
            transform.position-=transform.forward*speed*Time.deltaTime;
        }
        */

        
        /* Shige Rotate Logic
        if (Input.GetKey(KeyCode.A)){
            startTime= Time.time;
            startAngle= transform.rotation.y;
            targetAngle = transform.rotation.y -90.0f;
        }
        if (Input.GetKey(KeyCode.D)){
            startTime= Time.time;
            startAngle= transform.rotation.y;
            targetAngle = transform.rotation.y +90.0f;
        }

        if ( targetAngle!=transform.rotation.y)
        {
            Vector3 V = new Vector3(transform.rotation.x,transform.rotation.y,transform.rotation.z);
            V.y = Mathf.Lerp(startAngle,targetAngle,(Time.time-startTime)/turnTime);
            transform.eulerAngles = V;
        }
        */


    }


}
