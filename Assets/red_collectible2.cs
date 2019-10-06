using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_collectible2 : MonoBehaviour
{
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
        if(col.gameObject.name=="redball")
        {
            // print("Green Collectible Destroyed");
            ref1.GetComponent<span>().red_destroyed+=1;
            print(ref1.GetComponent<span>().red_destroyed);
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
