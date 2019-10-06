using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// collider abc;


public class green_collectible : MonoBehaviour
{
    // Start is called before the first frame update
    BoxCollider2D abc;
    public Rigidbody2D rb;
    public GameObject ref1;
    void Start()
    {
        abc=GetComponent<BoxCollider2D>();   
        rb=GetComponent<Rigidbody2D>();     
        ref1=GameObject.Find("BG");
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name=="ball")
        {
            // print("Green Collectible Destroyed");
            ref1.GetComponent<span>().green_destroyed+=1;
            print(ref1.GetComponent<span>().green_destroyed);
            Destroy(gameObject);
        }
        // else
            // abc.isTrigger=false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
