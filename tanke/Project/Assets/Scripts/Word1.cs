using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Word1 : MonoBehaviour
{
    string a2 = "PLAYER2"; 
    string b2 = "↑，↓，←，→移动，ENTER（小键盘）发射子弹";


    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Text>().text =  "<color=red>" + a2 + "</color>" + b2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
