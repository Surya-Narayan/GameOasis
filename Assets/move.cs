using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using WebSocketSharp;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=2f;
    public float thrust=5f;
    public float jump_time=0f;
    public float jf=0;
    public Rigidbody2D rb;
    public int green_inp=0;
    // public WebSocket //ws = new WebSocket ("10.2.88.162:21000");
    

    void Start()
    {
        rb=GetComponent<Rigidbody2D> ();
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name=="redball")
            SceneManager.LoadScene("End");
    }
 
    // Update is called once per frame
    void Update()
    {   
        ////ws.connect();
        //ws.OnMessage += (sender, e) => {};


        // if(rb.velocity.y==0)
        //     jump=0;
        if(green_inp == 3)
        {
            //ws.send("3");
            rb.velocity=new Vector2((Vector2.right*speed).x,rb.velocity.y);
            // transform.position=Vector2.right * speed * Time.deltaTime;
            // rb.AddForce(transform.forward * thrust);
            // jump=0;
        }
        if(green_inp == 4)
        {
            //ws.send("2");
            rb.velocity=new Vector2((Vector2.left*speed).x,rb.velocity.y);
            // transform.position=Vector2.right * speed * Time.deltaTime;
            // rb.AddForce(transform.forward * thrust);
            // jump=0;
        }

       if((green_inp == 1) && (Time.time -jump_time)>2)
        {
            //ws.send("1");
            // rb.velocity=new Vector2(rb.velocity.x,(Vector2.up*speed*4).y);
            // transform.position+=Vector2.up * speed * Time.deltaTime;
            Vector2 f=new Vector2(0,thrust*1.3f);
            // print(f);
            rb.AddForce(f,ForceMode2D.Impulse);
            jump_time=Time.time;
        }
        
        // print(speed);

        /*if(string.equals(e.data,"1"))
        {
           Vector2 f=new Vector2(0,thrust*1.3f);
            // print(f);
            rb.AddForce(f,ForceMode2D.Impulse);
            jump=1;
        }

        if(string.equals(e.data,"2"))
             rb.velocity=new Vector2((Vector2.left*speed).x,rb.velocity.y);

        if(string.equals(e.data,"3"))
            rb.velocity=new Vector2((Vector2.right*speed).x,rb.velocity.y);
*/
    }

}
