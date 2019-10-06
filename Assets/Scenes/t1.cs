using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using WebSocketSharp;
using System.Collections;
using UnityEngine.SceneManagement;

public class t1 : MonoBehaviour
{
    // Start is called before the first frame update
    // public 
    public Text abc;
    void Start()
    {   
        abc.text="A-Join Game\n\nB-Exit";
    
    }
 
    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("Game");
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            Application.Quit();
        }
    }
}