using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using WebSocketSharp;
using System.Collections;
using UnityEngine.SceneManagement;


public class countdown : MonoBehaviour
{
    // Start is called before the first frame update
    // public 
    public Text abc;
    public float starttime;
    public GameObject ref1;
    public GameObject bll;
    public GameObject rll;
    int grn;
    int s=0;
    int rd;
    Queue myQ = new Queue();
    string k;
    // myQ.Enqueue("00");
    public WebSocketSharp.WebSocket ws;

    void Start()
    {   
        // Uri q=new Uri("10.2.88.162:21000",)
        ws = new WebSocket("ws://10.2.88.162:21000");
        // print("egahjega0");
        // print(ws.GetType());
        ws.Connect();
        starttime=Time.time+120;
        // print(Time.time);
        ref1=GameObject.Find("BG");
        // abc.text="Hit Enter to Start";
        bll=GameObject.Find("ball");
        rll=GameObject.Find("redball");
        grn=bll.GetComponent<move>().green_inp;
        rd=rll.GetComponent<redmove>().red_inp;
        // print(typeof(ws.OnMessage));
        ws.OnMessage += (sender,e) => {
        myQ.Enqueue((string)e.Data);
        // print(typeof(e.Data));
        // Update(ws);
        };
    }
    // /*
    // 
    // */
    // Update is called once per frame
    void Update()
    {   

    	// bll.GetComponent<move>().green_inp = s;
        // // print("hnhfhnfhnf");
        // // print(myQ.Count);
        // if(Input.GetKeyDown(KeyCode.D))
        // {  
        //     ws.Send("g3");
        //     s=3;
        //     // print("rd");
            
        // }
        // if(Input.GetKeyDown(KeyCode.A))
        // { 
        //     ws.Send("g4");
        //     s=4;
        // }
        // if(Input.GetKeyDown(KeyCode.W))// && rll.GetComponent<redmove>().jump<1)
        // {   
        //     ws.Send("g1");
        //     s=1;
        // }

        if(myQ.Count!= 0){
        // print(myQ.Count);
        k = myQ.Dequeue().ToString();
        print(k);
        if(k[0] == 'g')
            bll.GetComponent<move>().green_inp = (int)k[1]-48;
        else if(k[0]=='r')
            rll.GetComponent<redmove>().red_inp = (int)k[1]-48;
        }
        // string k= myQ.Dequeue();
        grn =-1;
        float t=starttime-Time.time;
        if(ref1.GetComponent<span>().green_destroyed==5 && ref1.GetComponent<span>().red_destroyed==5)
        {
            abc.text="You Win!!!";
            /*if(Input.GetKeyDown(KeyCode.Escape))
            {
                ref1.GetComponent<span>().green_destroyed=0;
                ref1.GetComponent<span>().red_destroyed=0;
                starttime=Time.time+120;
                t=starttime-Time.time;
            }*/
        }
        else if(t<0)
        {
            abc.text="Time's Up";
            SceneManager.LoadScene("End");
            /*if(Input.GetKeyDown(KeyCode.Escape))
            {
                ref1.GetComponent<span>().green_destroyed=0;
                ref1.GetComponent<span>().red_destroyed=0;
                starttime=Time.time+120;
                t=starttime-Time.time;
                Instantiate(GameObject.Find("green_collectible1"));
            }*/
        }
        else
        {
        
        string seconds=(t%120).ToString("f2");
        abc.text=seconds;
        }
    }
}